/***************************************************************************
 
Copyright (c) Microsoft Corporation 2014.
 
This code is licensed using the Microsoft Public License (Ms-PL).  The text of the license can be found here:
 
http://www.microsoft.com/resources/sharedsource/licensingbasics/publiclicense.mspx
 
Published at http://OpenXmlDeveloper.org
Resource Center and Documentation: http://openxmldeveloper.org/wiki/w/wiki/powertools-for-open-xml.aspx
 
***************************************************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Validation;
using OpenXmlPowerTools;
using System.Text;
using DocumentFormat.OpenXml;
using System.Drawing.Imaging;

namespace OpenXmlPowerTools
{
    public static class AddDocxTextHelper
    {
        public static WmlDocument AppendParagraphToDocument(
            WmlDocument wmlDoc,
            string strParagraph,
            bool isBold,
            bool isItalic,
            bool isUnderline,
            string foreColor,
            string backColor,
            string styleName)
        {
            using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(wmlDoc))
            {
                using (WordprocessingDocument wDoc = streamDoc.GetWordprocessingDocument())
                {
                    StyleDefinitionsPart part = wDoc.MainDocumentPart.StyleDefinitionsPart;

                    Body body = wDoc.MainDocumentPart.Document.Body;

                    SectionProperties sectionProperties = body.Elements<SectionProperties>().FirstOrDefault();

                    Paragraph paragraph = new Paragraph();
                    Run run = paragraph.AppendChild(new Run());
                    RunProperties runProperties = new RunProperties();

                    if (isBold)
                        runProperties.AppendChild(new Bold());

                    if (isItalic)
                        runProperties.AppendChild(new Italic());


                    if (!string.IsNullOrEmpty(foreColor))
                    {
                        int colorValue = System.Drawing.Color.FromName(foreColor).ToArgb();
                        if (colorValue == 0)
                            throw new OpenXmlPowerToolsException(String.Format("Add-DocxText: The specified color {0} is unsupported, Please specify the valid color. Ex, Red, Green", foreColor));

                        string ColorHex = string.Format("{0:x6}", colorValue);
                        runProperties.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Color() { Val = ColorHex.Substring(2) });
                    }

                    if (isUnderline)
                        runProperties.AppendChild(new Underline() { Val = UnderlineValues.Single });

                    if (!string.IsNullOrEmpty(backColor))
                    {
                        int colorShade = System.Drawing.Color.FromName(backColor).ToArgb();
                        if (colorShade == 0)
                            throw new OpenXmlPowerToolsException(String.Format("Add-DocxText: The specified color {0} is unsupported, Please specify the valid color. Ex, Red, Green", foreColor));

                        string ColorShadeHex = string.Format("{0:x6}", colorShade);
                        runProperties.AppendChild(new Shading() { Fill = ColorShadeHex.Substring(2), Val = ShadingPatternValues.Clear });
                    }

                    if (!string.IsNullOrEmpty(styleName))
                    {
                        Style style = part.Styles.Elements<Style>().Where(s => s.StyleId == styleName).FirstOrDefault();
                        //if the specified style is not present in word document add it
                        if (style == null)
                        {
                            using (MemoryStream memoryStream = new MemoryStream())
                            {
                                #region Default.dotx Template has been used to get all the paragraph styles
                                string base64 =
        @"UEsDBBQABgAIAAAAIQDTMB8uXgEAACAFAAATAAAAW0NvbnRlbnRfVHlwZXNdLnhtbLSUy27CMBBF
95X6D5G3VWLooqoqAos+li1S6QcYewJW/ZI9vP6+EwKoqiCRCmwiJTP33jNWxoPR2ppsCTFp70rW
L3osAye90m5Wsq/JW/7IsoTCKWG8g5JtILHR8PZmMNkESBmpXSrZHDE8cZ7kHKxIhQ/gqFL5aAXS
a5zxIOS3mAG/7/UeuPQOwWGOtQcbDl6gEguD2euaPjckEUxi2XPTWGeVTIRgtBRIdb506k9Kvkso
SLntSXMd0h01MH40oa6cDtjpPuhoolaQjUXEd2Gpi698VFx5ubCkLNptjnD6qtISDvraLUQvISU6
c2sKBBtoAiis0G7Pf5Ij4cZAujxF49sdD4gkuAbAzrkTYQXTz6tR/DLvBKkodyKmBi6PcbDuhEDa
QGie/bM5tjZtkdQ5jj4k2uj4j7H3K1urcxo4QETd/tcdEsn67Pmgvg0UqCPZfHu/DX8AAAD//wMA
UEsDBBQABgAIAAAAIQAekRq37wAAAE4CAAALAAAAX3JlbHMvLnJlbHOsksFqwzAMQO+D/YPRvVHa
wRijTi9j0NsY2QcIW0lME9vYatf+/TzY2AJd6WFHy9LTk9B6c5xGdeCUXfAallUNir0J1vlew1v7
vHgAlYW8pTF41nDiDJvm9mb9yiNJKcqDi1kVis8aBpH4iJjNwBPlKkT25acLaSIpz9RjJLOjnnFV
1/eYfjOgmTHV1mpIW3sHqj1FvoYdus4ZfgpmP7GXMy2Qj8Lesl3EVOqTuDKNain1LBpsMC8lnJFi
rAoa8LzR6nqjv6fFiYUsCaEJiS/7fGZcElr+54rmGT827yFZtF/hbxucXUHzAQAA//8DAFBLAwQU
AAYACADRagZB/Fz9fNYBAAALAwAAEAAAAGRvY1Byb3BzL2FwcC54bWztvQdgHEmWJSYvbcp7f0r1
StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHKZVZlXWYWQMztnbz33nvvvffee++997o7nU4n
99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyL+x7/3H3z8e7xblOllXjdFtfzso93xzkdpvpxWs2J5
8dlH6/Z8++CjtGmz5Swrq2X+2UfXefPR73H0OFs9ellXq7xui7xJCcayeXTZfvbRvG1Xj+7ebabz
fJE1Y2qxpC/Pq3qRtfRnfXG3Oj8vpvnTarpe5Mv27t7Ozqd3Z9UU0JqffHO9IvgKL1t9XXj5uzZf
zvLZ9sri+BHj/CZfrMqszY8e3w3+wh9Vm5VvikV+tCNf2r95sNlF3hzt8jfyOz79blXPGm0vv+PT
k3lWZ9OWaKpfeR/g++PVqiymWUsUP/qimNZVU5236Zc8jhRg+CW/Fd6iEb7Op+u6aK8VrP8JWjwv
lrnpUn4XzOvsos5Wc/OV9wG+fz3NyvyE6HR0npVNzk3cZwr3bfPV6k31FLRyrcLPw5F/t2jnr1fZ
1CIU/Yr7py/yGY3F799+hhbfJqaoS3RGQJYX+cxr2f9OKfyTwtJHu/fHO/QYkpqPhRKWO47+H1BL
AwQUAAYACADRagZBUsP9QroBAABvAgAAEQAAAGRvY1Byb3BzL2NvcmUueG1s7b0HYBxJliUmL23K
e39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z28995777333nvvvfe6
O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8iHv8e7xZlepnXTVEtP/tod7zzUZovp9WsWF58
9tFXb55tH3yUNm22nGVltcw/++g6bz76PY6Sx9PVo2lV5y/rapXXbZE3KQFaNo+mq88+mrft6tHd
u810ni+yZkwtlvTleVUvspb+rC/urrLp2+wiv7u3s/Pp3UXeZrOsze4C4PbKQvxIQc6mFuRqXZcM
YDa9m5f5Il+2zd3d8e5d17bN60UTfYG/8VouivZ6lUebmi9t63dNYRteXV2Nr+5xU8J/9+7v/cXz
1zzU7WIJUk3zj44ez6aPpnWetVV9dJIVbVks0+NmXubX26+qslxky8d3vSYgZ5k17RdE+PMinz25
vsuf1fllgZk52n181//zsY5TAOSzlPB7JKMx33z33snTN88+Otrb2d3b3nmwvXf/ze6DR3v3H+3s
/BT6Dt53ABeKwW0g3nuzt/tovwPRADhijEMeOfp/AFBLAwQUAAYACAAAACEA1mSzUfQAAAAxAwAA
HAAAAHdvcmQvX3JlbHMvZG9jdW1lbnQueG1sLnJlbHOskstqwzAQRfeF/oOYfS07fVBC5GxKIdvW
/QBFHj+oLAnN9OG/r0hJ69BguvByrphzz4A228/BineM1HunoMhyEOiMr3vXKnipHq/uQRBrV2vr
HSoYkWBbXl5sntBqTkvU9YFEojhS0DGHtZRkOhw0ZT6gSy+Nj4PmNMZWBm1edYtyled3Mk4ZUJ4w
xa5WEHf1NYhqDPgftm+a3uCDN28DOj5TIT9w/4zM6ThKWB1bZAWTMEtEkOdFVkuK0B+LYzKnUCyq
wKPFqcBhnqu/XbKe0y7+th/G77CYc7hZ0qHxjiu9txOPn+goIU8+evkFAAD//wMAUEsDBBQABgAI
ANFqBkF65TN3MwIAAJAFAAARAAAAd29yZC9kb2N1bWVudC54bWztvQdgHEmWJSYvbcp7f0r1Stfg
dKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHKZVZlXWYWQMztnbz33nvvvffee++997o7nU4n99//
P1xmZAFs9s5K2smeIYCqyB8/fnwfPyL+x7/3H3z8e7xblOllXjdFtfzso93xzkdpvpxWs2J58dlH
6/Z8++CjtGmz5Swrq2X+2UfXefPR73H0+OrRrJquF/myTQnAsnl0tZp+9tG8bVeP7t5tpvN8kTXj
RTGtq6Y6b8fTanG3Oj8vpvndq6qe3d3b2d3h31Z1Nc2bhno7yZaXWfORglv0oVWrfElfnlf1Imvp
z/ri7iKr365X2wR9lbXFpCiL9ppg73xqwFQ0hnr5SEFsW4TwyiNBSH+YN+rb9CuvPFUKcI9367wk
HKplMy9WbhhfFxp9OTdALjcN4nJRmnZXq939D5uDp3V2RT8cwNugP5OXFqVgvhni7s4tZgQg7Bu3
QSHs02CyyIql6/hrkcYj7u799wOw1wWwung/AN3J+byu1isHrfgwaGfLtxYW5Po9YOkk+0Nr3gtA
D5nX82xFEriYPjq7WFZ1NikJI5qylKiegq0/gsaZVLNr/Fyld/Gjyafty5o/uHj9g/QKrLK7t7dP
Guzq0Zx+v3+A3+9Kiy+ymj5uK2Lp3X1pUxcX89b9Oanatlq4v8v83Pt2nmeznJTDgz3+87yqWu/P
i3XLf5r+plXZ0MfNKpvm2og+v+uQvmuGc9dp0qP/B1BLAwQUAAYACADRagZB3iZxVZoCAAAzBwAA
EgAAAHdvcmQvZm9udFRhYmxlLnhtbO29B2AcSZYlJi9tynt/SvVK1+B0oQiAYBMk2JBAEOzBiM3m
kuwdaUcjKasqgcplVmVdZhZAzO2dvPfee++999577733ujudTif33/8/XGZkAWz2zkrayZ4hgKrI
Hz9+fB8/Iv7Hv/cffPx7vFuU6WVeN0W1/Oyj3fHOR2m+nFazYnnx2Ufr9nz74KO0abPlLCurZf7Z
R9d589HvcfT46tF5tWyblN5eNo8W088+mrft6tHdu810ni+yZlyt8iV9eV7Vi6ylP+uLu4usfrte
bU+rxSpri0lRFu313b2dnU8/UjD1baBU5+fFNH9aTdeLfNny+3frvCSI1bKZF6vGQLu6DbSrqp6t
6mqaNw2NeFEKvEVWLC2Y3f0eoEUxraumOm/HNBjFiEHR67s7/NuidADuvx+APQtgMX10drGs6mxS
EukJk5SAfWSon149WmYL+uIkK4tJXfAXq2xZNfkufXeZlZ99tLO382znPv2L//Z37uHfj9K7aDmd
Z3WTt7bljn5+ni2K8tp83FwVTaPfrIp2OjdfXGZ1Abz0u6a4oG/WzWTns49Od+jZe/bsI/lk97OP
9umD4xP7yR6642dXP7lnP9nBJ1OGIy0ePtNPdv021OldIUOPHK+Lxev1kqmRle0L+szg/J//DX/s
f/b3/6lmND1K7e58SrDv0U/9L06pg0+jlMrWbfWehNLR3HOE2js4eGaI4BNq99MbCAUK774noY4J
sXKAa54QLfaVb/Z+aFyzd+xzzQl98uBg35DHcc3Dm7nm2ftyjQpR+ry4mLeDonTPkOOHJErHwHvv
tCNKezsPnvSIYnhmmCg77y1Kb4pF3qQv8qv0VbXIlgNk2SNeuUdaZp81zb33JEvNkN+PLD9sXtFf
mqP/B1BLAwQUAAQACADRagZBhoJdSR0EAAB5CQAAEQAAAHdvcmQvc2V0dGluZ3MueG1s7b0HYBxJ
liUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM7Z2899577733
3nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8i/se/9x98/Hu8W5TpZV43RbX87KPd
8c5Hab6cVrNiefHZR+v2fPvgo7Rps+UsK6tl/tlH13nz0e9x9PjqUZO3LTVqUgKwbB4tpp99NG/b
1aO7d5vpPF9kzbha5Uv68ryqF1lLf9YXdxdZ/Xa92p5Wi1XWFpOiLNrru3s7O59+pGAq6rRePlIQ
24tiWldNdd7ilUfV+XkxzfWHeaO+Tb/yytNqul7ky5Z7vFvnJeFQLZt5sWoMtMXXhUZfzg2Qy02D
uFyUpt3V7s4thntV1TP7xm3QwwuruprmTUMTtCgNgsXSdbzfA2T7HlPfOkQGRa/v7vBvPub33w/A
XgdAU95mJPLV82JSZ/W1P4zF9NHZxbKqs0lJPEnDSQmjj8CWNPDq/HWbtXlKPLrKy5I5eVrmGb13
9eiizhbEhfaTu3hplp9n67J9k01et9WKWl1mhN+DnQP9fn69mudL5pafIikwDfb37muD6Tyrs2mb
169X2ZQ6PKmWbV2VpuGselG1J8T0Nc2JeYVlAL9lq1V5/aTOs7f05qt1mTfSYt3kz06fZ9fVuvVf
eS2CR7CX2YJGHwjTF9UsxzDXdXH7CfrI4LlrxxPtqSI9URez/A3I/rq9LvNnNM7XxQ/y4+XsO+um
LQgkU+kDUNiIAU0Cdf0lccqb61X+LM/aNZH0Z6s3nrZnZbH6oqjrqj5bzkjcf/Z6K87P85p6KIh5
vyB2LOrqikn97TybkYb+0I7vOqZbPIK+elmb3zCP6UIan2SLSV1k6Res0e6iyaR++6RYmgaTnGQ0
D756vZ6Yb7e39ZtmkZXlMxIL882OfjErmtXT/Fz+KL/I6gsH27Sp4x+ToH7HwpsSrfL687par/Tr
qzpbySyZNrv7++bdYtk+Lxbmi2Y9eW3fW5J68b5bL2dfXtZCM0epq0ct0ZtZ/nnG88aNV+32k1eg
dJ417XFTZJ999IP59skLfDQpZjRdWb39+thMfVm/xrTlX5DUy+xPLnY/+6gsLubtLt5p6a8ZmUn+
Y3Kxp9/t8Xd78h3/kU1BAGqtv7jP9sxnXrt75rN77rN989m+++y++ey+++xT89mn+IyUYV6TVn1L
jGh+xefnVVlWV/ns2+773kdKhWaerfKnonSbo8eVfKBauEkvH+XvWhL2WdGS87EqZovsHU3lzt6n
/L42L0Uz+o3xHVqvQhCzrM2sEARvs1B0sIE5mBbEvK+vFxOnw8eKe1k0JLor0vdtVZsvR/Ll7n22
BO0b4npW5vn5k6zJZyp9xmU6+n8AUEsDBBQABAAIANFqBkEr9+zhUxIAABWtAAAPAAAAd29yZC9z
dHlsZXMueG1s7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVW
ZV1mFkDM7Z28995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8i/se/9x98
/Hu8W5TpZV43RbX87KPd8c5Hab6cVrNiefHZR+v2fPvgo7Rps+UsK6tl/tlH13nz0e9x9PjqUdNe
l3mT0uvL5tFi+tlH87ZdPbp7t5nO80XWjKtVvqQvz6t6kbX0Z31xd5HVb9er7Wm1WGVtMSnKor2+
u7ez8+lHCqa+DZTq/LyY5k+r6XqRL1t+/26dlwSxWjbzYtUYaFe3gXZV1bNVXU3zpqEhL0qBt8iK
pQWzu98DtCimddVU5+2YBqMYMSh6fXeHf1uUDsD99wOwZwEspo/OLpZVnU1Koj1hkhKwj0D+WTV9
mp9n67Jt8Gf9stY/9S/+8axatk169ShrpkXxhnomIIuC4H37eNkUH9E3c/wS/SbPmva4KTL/y1P9
DN9Pm9b75kkxo7fuMmP8gL69zMrPPtrbsx+dNL0Py2x5YT7Ml9tfvfZ7/eyjn862v/MSH00I9Gcf
ZfX262N+866O72531KvuX9z1KpsW3FF23ubEYDS/gFoW4Oa9B5+aP16tQeJs3Vaml5X24sO926M8
MR6x4WuRBvo2P39eTd/ms9ctffHZR9wZffjV2cu6qGri+M8+evhQP3ydL4pvF7NZvvQaLufFLP/u
PF9+1eQz9/lPPGOu1Q+m1XpJv997sMvcUDaz03fTfAUZoG+XGSbmBV4o0XpduM759V9kgO2ayYgB
mOcZ9EC624Xx8P1h7EVhNB4BpJfO6Hffv6d7P7Se9n9oPd3/ofX06Q+tpwc/tJ4Ofmg9PfxZ76lY
zvJ3IpG3AXsToL1vCtC9bwrQ/jcF6P43BejTbwrQg28K0ME3BejW7DkMqK2mfQNx7xsC3LMa3xTg
npH4pgD3bMI3BbhnAr4pwD2N/00B7in4bwpwT59/U4Af/mwAFjcsPSOBW7YfDu68qtpl1eZpm7/7
BsBlSwLGsdM3BBCmMK8/HA7G+U3AEUWnBvrDwU0z/rvHKLe2Nrc19C1ivrQ6T8+Li3VNUfct4Q9D
zJeXeUkhcJrNZgSw+eibg1jn7bpefjiKlrnr/DyvKRGRfzhMj8O/QagIGdPlejH5Jnh0lV18c8Dy
5eybJqEB+c1oCMvZFGzPIT/FN8Hdi4wyKh8Opq2yb05ZPC+ab4BegJI+WZdl/k0Be/ENsRoD+wZC
CIbzDUQQDOcbCCAYzq01+q1m7hsjk4L7pqil4L4poim4b4p2wqjfGO0U3DdFOwX3TdFOwX0DtHtT
tCWrfd9F2X2PzN9JWTXfiAZ8XVwsM/INvgEjpEnX9GVWZxd1tpqnSG/3RvnhHT2pZtfpm2/E1FlQ
35j7z5xyQgMvlutvgKgBuG9MzizAb0rSLMBvStYswG9A2r4gXxoO3Le/ocjn9XrSRgWYQd1OgF9n
5Vqc3g/H5yktZHw4FCcKz4q6+eYEIg73m2DlF3B5v/1N+YIOz28ANQfsG5CwrpL6ZhFUmN8EniUt
rH1Divnb16u8phju7YeDelaVZXWVz75BkK/buhKe8+V/j+fldvJ/uljNs6ZoejB8J+Amudcl9vSL
bPXhY3pZ0pr6NzR7p9u0QF+m36Bz8e03XzxP31QrhKUg8DcE8UnVttXimwOqucSt7+aTOx8OjVE8
prB5ef0N4CbQvqnUEkM7Kb4JyyOgqtk3BYoc0WJZfDO2lQH+Xvn1pMrq2TcE7iVlflhHtPk3BfJ1
tliV3xT93pCivCJ19E34SgzwJ7O6QE7pw8GpfL35ZqB5mcdmPfnpfPoNqL4XVfr8G8kqfbluOYcJ
aN/EenIA7xvwIAJ434D3wHNKJgOM/E2MN4D3DYw3gPeNjfekzJqm0BXabxLgNzZiA/AbH/I3ECoq
wKqs6vN1+Q0S0UD85qhoIH5zZKzK9WLZfKODZoDf5JgZ4Dc+5G+ScxjgN5BkEICf18Xsm5sRhvaN
TQdD+8bmgqF9YxPB0L7ZWfj0G4X24BuFdvBNQfumnAMP2jfGb9+sY8DQvjF+Y2jfGL8xtG+M3xga
89s3Bu0b47d7T9P8/Jwc5W/Q7ngwvzHe82B+YxyIlHS+WFV1Vl9/UzBPy/wi+yayrALuZV2dU3RP
X2TlNwUT2e7ym/TIBd43NtXfzSffHHIA9o1i9g1w35OM8pfVN5Wac1aIX/VSj/ce3vzem3m++AYC
b8o1TvN5VdJyzNCwhl+mCPv1Kptq0r+3tni7/Ovz4mLepq/nmVk88OF8unPzq9Crvfdu0WWM8p/u
bXrvi3xWrBcGV+H14O177/H2Xu/t/Vu8zUak3/H9277a7/XTW7zqnOng1Qe3fbXf68FtX73Xe3Wj
cDzN6rdRjniwkZNsUDjAhw828pN9O9rxRpayr8a48cFGfgoEh5LTUyxA9CfplhI0DOCWojQM4L1k
ahjMewnXMJjbS9kwjI3i9iq/LGD430uVco8vszq7qLPVvGcQ2N2+nT79iTUtxnYB7D28PYAzcq6W
TZ5GAd17j1WxQO8ME/P2CmgYxu010TCM26ukYRi3002D77+fkhoGc3ttNQzj9mprGMb766++pXhP
/dUH8J76qw/ga+mvPpivpb8+xEsYhnF7d2EYxvuLbR/G+4vth3gSwzBuFNvNLPb1xLYP5v3Ftg/j
/cW2D+P9xbbvpb2n2PYBvKfY9gF8LbHtg/laYtsH8/5i24fx/mLbh/H+YtuH8f5i24fx/mL7dSOB
wfe/ntj2wby/2PZhvL/Y9mG8v9ju90j6nmLbB/CeYtsH8LXEtg/ma4ltH8z7i20fxvuLbR/G+4tt
H8b7i20fxvuLbR/G+4lt7/2vJ7Z9MO8vtn0Y7y+2fRjvL7b3eyR9T7HtA3hPse0D+Fpi2wfztcS2
D+b9xbYP4/3Ftg/j/cW2D+P9xbYP4/3Ftg/j/cS29/7XE9s+mPcX2z6M9xfbPoz3F9tPeyR9T7Ht
A3hPse0D+Fpi2wfztcS2D+b9xbYP4/3Ftg/j/cW2D+P9xbYP4/3Ftg/j/cS29/7XE9s+mPcX2z6M
9xfbPoyNnKoroqeL1Txrisa9LC/vPsQnt0t+mizqEKy93dvDUrRe5ed5nS+n/aTse8AyeA0D27s9
sCdV9TZ9UxByPSj33gNKMSmLihPf1z04D/DJh61xvvnyJP12zvzZA//wtuBvOxhaUC1ohZjXaHe7
3e3f+tVeUmZ/I/P7r/YCw/2NPO+/2nNO9zdqZP/VnoHc36iIWUjlTTZTvbc3qh3v7d2B9zeqcO/9
PqE3Km7vzT6dN6pr780+mTcqae/N+yk0dvf1+7cl1qep0ZI9EBs50wPxYBjERg7tT5nR0X0pufXc
DYO49SQOg7j1bA6DeL9pHYTzNeZ3GNb7T/QwrK85432Ze+8Z/wCxHQbx3jPeB/H1ZrwH5wNmvA/r
6894H9bXnPG+rnzvGe+DeO8Z/wCNPQzi6814D84HzHgf1tef8T6srznjfRv33jPeB/HeM94H8d4z
/qHGehDOB8x4H9bXn/E+rK85430P8L1nvA/ivWe8D+K9Z7wP4uvNeA/OB8x4H9bXn/E+rK85473o
+v1nvA/ivWe8D+K9Z7wPojPjt5zxHpwPmPE+rK8/431YG2f8ObIwwYy/30R777+nn+a9+Z7G2nvz
PTW29+bXCa+8179ueOWB+LrhVX/KzNy/Z3jlz90wiFtP4jCIW8/mMIj3m9ZBOF9jfodhvf9ED8P6
mjP+nuFVbMY/QGyHQbz3jL9neDU44+8ZXm2c8fcMrzbO+HuGV8Mz/p7hVWzG3zO8is34B2jsYRBf
b8bfM7zaOOPvGV5tnPH3DK+GZ/w9w6vYjL9neBWb8fcMr2Iz/qHGehDOB8z4e4ZXG2f8PcOr4Rl/
z/AqNuPvGV7FZvw9w6vYjL9neDU44+8ZXm2c8fcMrzbO+HuGV8Mz/p7hVWzG3zO8is34e4ZXsRl/
z/BqcMbfM7zaOOPvGV5tnPGh8OouActoubV93V6XeQPgDX6j1u31iqCusjrjdU8A4K/OaLXxBdYZ
2f+f5efZuuQlR7wMVOjTy6x0jRhlXZrUPhnQbTvThdF+B3P5IjVkmWS0FPrlMtr/Mn/XRr8oi+Vb
84Xp6WSe1fq1o5lpZBjDG9HVo9XLGj/e5vnqBXq6a/56XizzRv5sVtkU6BKi+XlV5+DTHYw0O2/z
+rOPDKdU65aQyp9flqbLHTNX2k2tP55Vy7YBgGZaFG/mOdhgkf10VX/7eNkUAD3HL9Fv8qxpj5si
87881c/w/bRpvW+eFLPCUFl/nOiwpmA1g+ne6YP9J6xe+G1mw88+ypgJd+3Hr+fZjCA/eaYgmx/Y
943kNj84wcj8D+/qwL8m/+wN8o9Rft8U/+zdin/ckr62DFb0vzEe29u5HY/tGhr/v57H7j95+OTp
MI91OcpYpICjPjWj/RCOujfIUfe+YY669/9FjrIW5v8HHPWBnLI/yCn73zCn7P9/kVPuGRr/v5FT
Cv3xc8M59wc55/43zDn3/7/IOfuGxv9v4JyAM3af7T99cHBLT+jBMzOOD+GVTwd5xdjAb4pXPv3/
Iq/cNzT+fwOvbNQqPwe882CQd0w4/k3xzoP/L/KO9Rf/X887+zv4r8s7LZHEcc6bYtna8OsDGedg
kHFMKPdNMc7B/xcZ54Gh8c8249yGcd7TdbnywygzxCCMsomJD+Ggh4McZOb0m+Kgh/9f5CCb/Ph/
Awd9s6rnm2OwKU1sNiVKBgz2VJKTLw33gWRosCFpqa+k9p1UXhrgGSsoN/LMMO4tcrYB3pzFNcx8
ixyrpH2HGft9OLudlMJg9MvZckYwrpg7Dbazd5lCowYneVl+kUnzarWhbZmft/L17s5BrMGkattq
sQFCzesOwyDuhgjJn5uZZrleTPKapDIg/osKmfQb6Z5Kqw8n+ftqzTdFS3PdRUg+VVp+qLpkYBt1
5a6R1pgiXD2Z8U87p/xKQ4QWPp+KYrjBAEETsPYT5Zn7wZ524JSqatF7olOhQUl57Ns/Xq1L+iBb
t5W1hEvopXVWvlYY/+/RsYFOvbd373T/WUyn7tkPe+l0SxYx9D1da5f7fF3rVoS+lq71eIaGsG5o
5l/ju5j0cNvUY7AOx8b1dpxNb2bRH03me+uY1+tJG1Uz9otvSNMYeJuVjbGyMWVDSlx+KcrIYoZ+
+/8Syf7AVGKPGXb73LBnEsqBG2U159cS7XCSbpRu0/zDBbzDbRs440fT+v7TqkGRrnbfOK3aPN39
8Hk1PQ/Oq/Gefk6ndaI//l+40B2ZUDehuvx86wnd+8Ym1Fii/y9O6K3k1E3fB60qb5w+Xeu99fTd
+8amz6xa//9z+j5wWnRh9dbTsv+NTYtR/f8fmZYPtIYfOE26innrabr/jU2TMdr/L52mH8IC08aJ
0SXDW0/Mp9/YxBhV/f/Sifk5WAncOFG6PnfriXrwjU2UWWn8/+JEvXfu+wNnSRfDbj1LB9/YLBnH
9f+ls/Se5iZw6n4WliCUaLrydOvpeviNTZeZlP+XTtc3K1Q/27OJhESZny5W86wpmmjmg2DY7993
+iIJDjNJQepLZ2wj7Q528N9taPeBZmOQGt8gGexc3kyGrzuMM1oQWDbDc6vff5OTu2dUUGxUE4V/
W7f6Z8mtft3WFS2Q9ThdPv4GaLB3axrcPIRVNJn9E+uqzXsjkE+jA3j/NDYD8zR2ZJxfW5B3+BkQ
5FuRJT6zHs43miVu++Emyaf5BhL9cKgSZxYV8zjPGB3wjfKO3+NGFrr3w1pz3edfblxzneTnVZ1D
OfM86BLs3oFBs1jOUln5J1/j3qdow4v4+peCVefj/1VKrz8lN0pIwBofLikBG97IEP/vop54Qa/y
87zOl9O+FKmX5Bq8L6EilNhkSRuSu/IkW8WocPr0wdN7zPh9KhjLtO5K0wfQRud1mDiGj75R6tze
xn44tQbWq79JIj6pqrdvosvT+CZ9M7xA/X5kM/nwr0G2KBVuHm/cJhHYtqiWvdFO9fPoUG9niCKj
touP+aL4djGb5UttupwXs/y783z5FXUUoYyqcjd0UmgwDxLB4Y9XayjPbN1Wt1P/76mwrrzobze2
vqYfft15ePPliQbVvamgr1LzXXQ69EuD6PtMiHGLvu6EVOsWxH9+WRqQDw0ZVl+HDC+q1zLFPSq8
qFLz1dBoooq6xznqS1jGuQ0XuWGY35qj/wdQSwMEFAAGAAgA0WoGQQnbwwXdBgAAUBsAABUAAAB3
b3JkL3RoZW1lL3RoZW1lMS54bWztvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLs
HWlHIymrKoHKZVZlXWYWQMztnbz33nvvvffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/
fnwfPyL+x7/3H3z8e7xblOllXjdFtfzso93xzkdpvpxWs2J58dlH6/Z8++CjtGmz5Swrq2X+2UfX
efPR73H0OHvUzvNFntLby4Z+X+ze/+yjeduuHt2920zpq6wZL4ppXTXVeTueVou71fl5Mc3v8muL
8u7ezu7e3UVWLD9SGFnv/WqVL+m786peZC39WV/cndXZFWHG7+98qu8vswUh9iXDT98A/kcWwdOS
/lm2DT6YlvXrKWPtv8FtZ2938aO5bk7KOr3Mys8+on5m1dWb/F37UVpmTUtffPbRDj8fpXePHt+1
b5XtwMvei8/4MS/qG7O3e/xifTGxb+7v39//9Nj1sCc99BuePjj99PRTB5FbZNMpjXa31/j+k4dP
nt43jb1W8msE+tMHT+/thi94PdzrvXB8H/+FL9xzL+z3Xnj27MQjpddKfr0focyDvZP98IX77oVP
ey882Dl+uv8gfIFbzcti+bbXfOf+p/dO7JBtm/Oq/Ha0/cP7+88e7Jn2rtldj9MEwLId4rtF9tNV
/Ywa8CxnbbFM2+tVfp5Nqd1JVhaTukifFxdzYsJVtqwa+nhnb+fZzj36F//t829ClexRnnmv62fT
pv8ZUEqbaV2s2s8++g4B/shr8z/+fX/9//j3/a3pf/qH/G3/6R/yd/6nf+gf+p/+IX9j7LVvZ8sL
/7X/9q/8k/+7P/8PSv+bv/Uv+m//tD994IXGf+E//xv+2P/s7/9TB1q2fsv/4s/4m/7Lv+1v+i/+
rD/hv/5r/7RY++M6m/jt3xSLvElf5Ffpq2qBwUW6yCf1e77yZp4V/ivHy4smW2Z4Kdb8tJ0HzV9c
Z2UWa/gkDwn5kzUpj2jLz9c/HSD9el6v2yLW8veaL4KWX1RV+aSq4wP7vbg7jxbr5cVA//Xab/gq
yy6j3Z90pvp0vSL+L6JAT+Z5gOrLkmY/u8iXeZviu+ptnsfe+32KIqDvF8bapL9PkT7Jijhh3hST
gLXcW98uFjRB11EcaeoDCn3xk+mTqox28DS/DJuSmGRlFGheBtT8PFu32SKOdbYo/abPs3YeRfT1
dT0NCN+0NOkXeVmlp7O8aaIvfVlfByj/XqR3Bjjgi/J6ETat2+JttOnzrKr8pk+rtyfzbLGK410s
537js+YtcWyWvqzaOB5VKDP4myYkWw7P/E8WeTDzt5D4r0jxxpkF36zrqIzkVSij1+V5lgv4ux2F
vyiWN2r/jt6//7Ou90nN/hd/3p8/oJb/36rxj+siLmRdPT/YsKvdT6p6Vvx/Q7k/zdbLlzkEKNL2
R7r9/Ee63VfYPx90+6CU/2xodKfE78qbnuu/GPT8z4uyfN1el/nzhtV/Q0OcPaMP+Q9+yUYaqzn9
avoLGl7UGf+e1lX73aKdv55nK+pnl7u4aBT2RZOuqoYsyEchcA84vijXiy+qmXS5u2sDXeoya90X
ZILsF2SxWvn40wdeMGfR578uGh+H+wz39nj43YV43Ivh8cB+egMePL5vBpGHMUQOdjcictebHpLI
NEO65f6+pheaaVbmM0yYAjDz/I3P+SBJw7HvxYb4cH/jEN9rzgM8fN4L8fCZcp7N8t7n3/CsP/Tm
NkBxz/YYYPLg4Gdn1u/2FUa5DP9Kr0gK792nl6fZ6rOPzsmfpF8XKwLYQKFm5QUl+Kat0vtrqZtV
3bRPs2Yu7fgrpcGiaPM6LYsFcX4wG+XSobe79wBf/L8Xv4c7/6+k393ubOfn5/m0HfjE/UnfKZTo
1x/aGn9Ua8L79Xx2lU7Kdf0qI2rdf7ALKs6KprUknRW1x+iOlB0dppIZZOWcxGblap6puQnUvLTn
3y0+3kAY1e6wwr91NJOLZx0p+3rzfPNb+MLTpEO25YEQLKZPfvb8AA8vzyAEeN23eAXq76FVf4MG
5MNNhYee112A3j2G0kfP+zhE75v0GrwOHZt2EHTm4xu3E10evuu5ofxXb12kmvw0ycFTcm/XZdsI
trTsUWcnJo2tqoE/NgrnXZuu6+Kzj37xzv3j/ZO9+yfbOwf3T7f37+3vbB/cP763fXz//r3d0/u7
O0+f7P0SogwvEknvzygWKq+/kcWjyOJPWhBxfvGne88e3nv45NPth/eOn23vP31ysP3w5NMn208/
PXnw9NnTk/sHD5/9ko/SS268f3zvZP/T04PtT3dPTrb3P90B+gcPtx/s7+0d7z84PjjdP/4lhtw0
dPPTUJgRO/p/AFBLAwQUAAYACADRagZBjoxzCXABAAD0AQAAFAAAAHdvcmQvd2ViU2V0dGluZ3Mu
eG1s7b0HYBxJliUmL23Ke39K9UrX4HShCIBgEyTYkEAQ7MGIzeaS7B1pRyMpqyqBymVWZV1mFkDM
7Z28995777333nvvvfe6O51OJ/ff/z9cZmQBbPbOStrJniGAqsgfP358Hz8i/se/9x98/Hu8W5Tp
ZV43RbX87KPd8c5Hab6cVrNiefHZR+v2fPvgo7Rps+UsK6tl/tlH13nz0e9x9Pjq0VU+eZ23LbVr
UoKxbB4tpp99NG/b1aO7d5vpPF9kzbha5Uv68ryqF1lLf9YXdxdZ/Xa92p5Wi1XWFpOiLNrru3s7
O59+pGDq20Cpzs+Laf60mq4X+bLl9+/WeUkQq2UzL1aNgXZ1G2hXVT1b1dU0bxoaz6IUeIusWFow
u/s9QItiWldNdd6OaTCKEYOi13d3+LdF6QDcfz8AexbAYvro7GJZ1dmkpAkgTFIC9hHmoFq1xaL4
Qf6sqp/U1VWT1+ldfJ6VZXX18sXn+OtuMFVH/w9QSwECLQAUAAYACAAAACEA0zAfLl4BAAAgBQAA
EwAAAAAAAAAAAAAAAAAAAAAAW0NvbnRlbnRfVHlwZXNdLnhtbFBLAQItABQABgAIAAAAIQAekRq3
7wAAAE4CAAALAAAAAAAAAAAAAAAAAI8BAABfcmVscy8ucmVsc1BLAQItABQABgAIANFqBkH8XP18
1gEAAAsDAAAQAAAAAAAAAAAAAAAAAKcCAABkb2NQcm9wcy9hcHAueG1sUEsBAi0AFAAGAAgA0WoG
QVLD/UK6AQAAbwIAABEAAAAAAAAAAAAAAAAAqwQAAGRvY1Byb3BzL2NvcmUueG1sUEsBAi0AFAAG
AAgAAAAhANZks1H0AAAAMQMAABwAAAAAAAAAAAAAAAAAlAYAAHdvcmQvX3JlbHMvZG9jdW1lbnQu
eG1sLnJlbHNQSwECLQAUAAYACADRagZBeuUzdzMCAACQBQAAEQAAAAAAAAAAAAAAAADCBwAAd29y
ZC9kb2N1bWVudC54bWxQSwECLQAUAAYACADRagZB3iZxVZoCAAAzBwAAEgAAAAAAAAAAAAAAAAAk
CgAAd29yZC9mb250VGFibGUueG1sUEsBAi0AFAAEAAgA0WoGQYaCXUkdBAAAeQkAABEAAAAAAAAA
AAAAAAAA7gwAAHdvcmQvc2V0dGluZ3MueG1sUEsBAi0AFAAEAAgA0WoGQSv37OFTEgAAFa0AAA8A
AAAAAAAAAAAAAAAAOhEAAHdvcmQvc3R5bGVzLnhtbFBLAQItABQABgAIANFqBkEJ28MF3QYAAFAb
AAAVAAAAAAAAAAAAAAAAALojAAB3b3JkL3RoZW1lL3RoZW1lMS54bWxQSwECLQAUAAYACADRagZB
joxzCXABAAD0AQAAFAAAAAAAAAAAAAAAAADKKgAAd29yZC93ZWJTZXR0aW5ncy54bWxQSwUGAAAA
AAsACwDBAgAAbCwAAAAA";
                                #endregion

                                char[] base64CharArray = base64.Where(c => c != '\r' && c != '\n').ToArray();
                                byte[] byteArray = System.Convert.FromBase64CharArray(base64CharArray, 0, base64CharArray.Length);
                                memoryStream.Write(byteArray, 0, byteArray.Length);

                                using (WordprocessingDocument defaultDotx = WordprocessingDocument.Open(memoryStream, true))
                                {
                                    //Get the specified style from Default.dotx template for paragraph
                                    Style templateStyle = defaultDotx.MainDocumentPart.StyleDefinitionsPart.Styles.Elements<Style>().Where(s => s.StyleId == styleName && s.Type == StyleValues.Paragraph).FirstOrDefault();

                                    //Check if the style is proper style. Ex, Heading1, Heading2
                                    if (templateStyle == null)
                                        throw new OpenXmlPowerToolsException(String.Format("Add-DocxText: The specified style name {0} is unsupported, Please specify the valid style. Ex, Heading1, Heading2, Title", styleName));
                                    else
                                        part.Styles.Append((templateStyle.CloneNode(true)));
                                }
                            }
                        }

                        paragraph.ParagraphProperties = new ParagraphProperties(new ParagraphStyleId() { Val = styleName });
                    }

                    run.AppendChild(runProperties);
                    run.AppendChild(new Text(strParagraph));

                    if (sectionProperties != null)
                        body.InsertBefore(paragraph, sectionProperties);
                    else
                        body.AppendChild(paragraph);
                }
                return streamDoc.GetModifiedWmlDocument();
            }
        }
    }

    public class HtmlConverterHelper
    {
        public static void ConvertToHtml(string file, string outputDirectory)
        {
            var fi = new FileInfo(file);
            byte[] byteArray = File.ReadAllBytes(fi.FullName);
            using (MemoryStream memoryStream = new MemoryStream())
            {
                memoryStream.Write(byteArray, 0, byteArray.Length);
                using (WordprocessingDocument wDoc = WordprocessingDocument.Open(memoryStream, true))
                {
                    var destFileName = new FileInfo(fi.Name.Replace(".docx", ".html"));
                    if (outputDirectory != null && outputDirectory != string.Empty)
                    {
                        DirectoryInfo di = new DirectoryInfo(outputDirectory);
                        if (!di.Exists)
                        {
                            throw new OpenXmlPowerToolsException("Output directory does not exist");
                        }
                        destFileName = new FileInfo(Path.Combine(di.FullName, destFileName.Name));
                    }
                    var imageDirectoryName = destFileName.FullName.Substring(0, destFileName.FullName.Length - 5) + "_files";
                    int imageCounter = 0;
                    var pageTitle = (string)wDoc.CoreFilePropertiesPart.GetXDocument().Descendants(DC.title).FirstOrDefault();
                    if (pageTitle == null)
                        pageTitle = fi.FullName;

                    HtmlConverterSettings settings = new HtmlConverterSettings()
                    {
                        PageTitle = pageTitle,
                        FabricateCssClasses = true,
                        CssClassPrefix = "pt-",
                        RestrictToSupportedLanguages = false,
                        RestrictToSupportedNumberingFormats = false,
                        ImageHandler = imageInfo =>
                        {
                            DirectoryInfo localDirInfo = new DirectoryInfo(imageDirectoryName);
                            if (!localDirInfo.Exists)
                                localDirInfo.Create();
                            ++imageCounter;
                            string extension = imageInfo.ContentType.Split('/')[1].ToLower();
                            ImageFormat imageFormat = null;
                            if (extension == "png")
                            {
                                // Convert png to jpeg.
                                extension = "gif";
                                imageFormat = ImageFormat.Gif;
                            }
                            else if (extension == "gif")
                                imageFormat = ImageFormat.Gif;
                            else if (extension == "bmp")
                                imageFormat = ImageFormat.Bmp;
                            else if (extension == "jpeg")
                                imageFormat = ImageFormat.Jpeg;
                            else if (extension == "tiff")
                            {
                                // Convert tiff to gif.
                                extension = "gif";
                                imageFormat = ImageFormat.Gif;
                            }
                            else if (extension == "x-wmf")
                            {
                                extension = "wmf";
                                imageFormat = ImageFormat.Wmf;
                            }

                            // If the image format isn't one that we expect, ignore it,
                            // and don't return markup for the link.
                            if (imageFormat == null)
                                return null;

                            string imageFileName = imageDirectoryName + "/image" +
                                imageCounter.ToString() + "." + extension;
                            try
                            {
                                imageInfo.Bitmap.Save(imageFileName, imageFormat);
                            }
                            catch (System.Runtime.InteropServices.ExternalException)
                            {
                                return null;
                            }
                            XElement img = new XElement(Xhtml.img,
                                new XAttribute(NoNamespace.src, imageFileName),
                                imageInfo.ImgStyleAttribute,
                                imageInfo.AltText != null ?
                                    new XAttribute(NoNamespace.alt, imageInfo.AltText) : null);
                            return img;
                        }
                    };
                    XElement html = HtmlConverter.ConvertToHtml(wDoc, settings);

                    // Note: the xhtml returned by ConvertToHtmlTransform contains objects of type
                    // XEntity.  PtOpenXmlUtil.cs define the XEntity class.  See
                    // http://blogs.msdn.com/ericwhite/archive/2010/01/21/writing-entity-references-using-linq-to-xml.aspx
                    // for detailed explanation.
                    //
                    // If you further transform the XML tree returned by ConvertToHtmlTransform, you
                    // must do it correctly, or entities will not be serialized properly.

                    var htmlString = html.ToString(SaveOptions.DisableFormatting);
                    File.WriteAllText(destFileName.FullName, htmlString, Encoding.UTF8);
                }
            }
        }
    }

    public class ValidationHelper
    {
        public static bool IsValid(string fileName, string officeVersion)
        {
            FileFormatVersions fileFormatVersion;
            if (!Enum.TryParse(officeVersion, out fileFormatVersion))
                fileFormatVersion = FileFormatVersions.Office2013;

            FileInfo fi = new FileInfo(fileName);
            if (Util.IsWordprocessingML(fi.Extension))
            {
                using (WordprocessingDocument wDoc = WordprocessingDocument.Open(fileName, false))
                {
                    OpenXmlValidator validator = new OpenXmlValidator(fileFormatVersion);
                    var errors = validator.Validate(wDoc);
                    bool valid = errors.Count() == 0;
                    return valid;
                }
            }
            else if (Util.IsSpreadsheetML(fi.Extension))
            {
                using (SpreadsheetDocument sDoc = SpreadsheetDocument.Open(fileName, false))
                {
                    OpenXmlValidator validator = new OpenXmlValidator(fileFormatVersion);
                    var errors = validator.Validate(sDoc);
                    bool valid = errors.Count() == 0;
                    return valid;
                }
            }
            else if (Util.IsPresentationML(fi.Extension))
            {
                using (PresentationDocument pDoc = PresentationDocument.Open(fileName, false))
                {
                    OpenXmlValidator validator = new OpenXmlValidator(fileFormatVersion);
                    var errors = validator.Validate(pDoc);
                    bool valid = errors.Count() == 0;
                    return valid;
                }
            }
            return false;
        }

        public static IEnumerable<ValidationErrorInfo> GetOpenXmlValidationErrors(string fileName,
            string officeVersion)
        {
            FileFormatVersions fileFormatVersion;
            if (!Enum.TryParse(officeVersion, out fileFormatVersion))
                fileFormatVersion = FileFormatVersions.Office2013;

            FileInfo fi = new FileInfo(fileName);
            if (Util.IsWordprocessingML(fi.Extension))
            {
                WmlDocument wml = new WmlDocument(fileName);
                using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(wml))
                using (WordprocessingDocument wDoc = streamDoc.GetWordprocessingDocument())
                {
                    OpenXmlValidator validator = new OpenXmlValidator(fileFormatVersion);
                    var errors = validator.Validate(wDoc);
                    return errors.ToList();
                }
            }
            else if (Util.IsSpreadsheetML(fi.Extension))
            {
                SmlDocument Sml = new SmlDocument(fileName);
                using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(Sml))
                using (SpreadsheetDocument wDoc = streamDoc.GetSpreadsheetDocument())
                {
                    OpenXmlValidator validator = new OpenXmlValidator(fileFormatVersion);
                    var errors = validator.Validate(wDoc);
                    return errors.ToList();
                }
            }
            else if (Util.IsPresentationML(fi.Extension))
            {
                PmlDocument Pml = new PmlDocument(fileName);
                using (OpenXmlMemoryStreamDocument streamDoc = new OpenXmlMemoryStreamDocument(Pml))
                using (PresentationDocument wDoc = streamDoc.GetPresentationDocument())
                {
                    OpenXmlValidator validator = new OpenXmlValidator(fileFormatVersion);
                    var errors = validator.Validate(wDoc);
                    return errors.ToList();
                }
            }
            return Enumerable.Empty<ValidationErrorInfo>();
        }
    }

    public class DocxMetrics
    {
        public string FileName;

	    public int ActiveX;
	    public int AltChunk;
	    public int AsciiCharCount;
	    public int AsciiRunCount;
	    public int AverageParagraphLength;
	    public int ComplexField;
	    public int ContentControlCount;
	    public XmlDocument ContentControls;
	    public int CSCharCount;
	    public int CSRunCount;
	    public bool DocumentProtection;
	    public int EastAsiaCharCount;
	    public int EastAsiaRunCount;
	    public int ElementCount;
	    public bool EmbeddedXlsx;
	    public int HAnsiCharCount;
	    public int HAnsiRunCount;
	    public int Hyperlink;
	    public bool InvalidSaveThroughXslt;
	    public string Languages;
	    public int LegacyFrame;
	    public int MultiFontRun;
	    public string NumberingFormatList;
	    public int ReferenceToNullImage;
	    public bool RevisionTracking;
	    public int RunCount;
	    public int SimpleField;
	    public XmlDocument StyleHierarchy;
	    public int SubDocument;
	    public int Table;
	    public int TextBox;
	    public bool TrackRevisionsEnabled;
	    public bool Valid;
        public int ZeroLengthText;
    }

    public static class GetMetricsHelper
    {
        public static DocxMetrics GetDocxMetrics(string fileName)
        {
            WmlDocument wmlDoc = new WmlDocument(fileName);
            MetricsGetterSettings settings = new MetricsGetterSettings();
            settings.IncludeTextInContentControls = false;
            settings.IncludeXlsxTableCellData = false;
            var metricsXml = MetricsGetter.GetDocxMetrics(wmlDoc, settings);
            DocxMetrics metrics = new DocxMetrics();
            metrics.FileName = wmlDoc.FileName;

            metrics.StyleHierarchy         = GetXmlDocumentForMetrics(metricsXml, H.StyleHierarchy);
            metrics.ContentControls        = GetXmlDocumentForMetrics(metricsXml, H.Parts);
            metrics.TextBox                = GetIntForMetrics(metricsXml, H.TextBox);
            metrics.ContentControlCount    = GetIntForMetrics(metricsXml, H.ContentControl);
            metrics.ComplexField           = GetIntForMetrics(metricsXml, H.ComplexField);
            metrics.SimpleField            = GetIntForMetrics(metricsXml, H.SimpleField);
            metrics.AltChunk               = GetIntForMetrics(metricsXml, H.AltChunk);
            metrics.Table                  = GetIntForMetrics(metricsXml, H.Table);
            metrics.Hyperlink              = GetIntForMetrics(metricsXml, H.Hyperlink);
            metrics.LegacyFrame            = GetIntForMetrics(metricsXml, H.LegacyFrame);
            metrics.ActiveX                = GetIntForMetrics(metricsXml, H.ActiveX);
            metrics.SubDocument            = GetIntForMetrics(metricsXml, H.SubDocument);
            metrics.ReferenceToNullImage   = GetIntForMetrics(metricsXml, H.ReferenceToNullImage);
            metrics.ElementCount           = GetIntForMetrics(metricsXml, H.ElementCount);
            metrics.AverageParagraphLength = GetIntForMetrics(metricsXml, H.AverageParagraphLength);
            metrics.RunCount               = GetIntForMetrics(metricsXml, H.RunCount);
            metrics.ZeroLengthText         = GetIntForMetrics(metricsXml, H.ZeroLengthText);
            metrics.MultiFontRun           = GetIntForMetrics(metricsXml, H.MultiFontRun);
            metrics.AsciiCharCount         = GetIntForMetrics(metricsXml, H.AsciiCharCount);
            metrics.CSCharCount            = GetIntForMetrics(metricsXml, H.CSCharCount);
            metrics.EastAsiaCharCount      = GetIntForMetrics(metricsXml, H.EastAsiaCharCount);
            metrics.HAnsiCharCount         = GetIntForMetrics(metricsXml, H.HAnsiCharCount);
            metrics.AsciiRunCount          = GetIntForMetrics(metricsXml, H.AsciiRunCount);
            metrics.CSRunCount             = GetIntForMetrics(metricsXml, H.CSRunCount);
            metrics.EastAsiaRunCount       = GetIntForMetrics(metricsXml, H.EastAsiaRunCount);
            metrics.HAnsiRunCount          = GetIntForMetrics(metricsXml, H.HAnsiRunCount);
            metrics.RevisionTracking       = GetBoolForMetrics(metricsXml, H.RevisionTracking);
            metrics.EmbeddedXlsx           = GetBoolForMetrics(metricsXml, H.EmbeddedXlsx);
            metrics.InvalidSaveThroughXslt = GetBoolForMetrics(metricsXml, H.InvalidSaveThroughXslt);
            metrics.TrackRevisionsEnabled  = GetBoolForMetrics(metricsXml, H.TrackRevisionsEnabled);
            metrics.DocumentProtection     = GetBoolForMetrics(metricsXml, H.DocumentProtection);
            metrics.Valid                  = GetBoolForMetrics(metricsXml, H.Valid);
            metrics.Languages              = GetStringForMetrics(metricsXml, H.Languages);
            metrics.NumberingFormatList    = GetStringForMetrics(metricsXml, H.NumberingFormatList);

            return metrics;
        }

        private static string GetStringForMetrics(XElement metricsXml, XName xName)
        {
            var ele = metricsXml.Element(xName);
            if (ele == null)
                return "";
            return (string)ele.Attribute(H.Val);
        }

        private static bool GetBoolForMetrics(XElement metricsXml, XName xName)
        {
            var ele = metricsXml.Element(xName);
            if (ele == null)
                return false;
            return (bool)ele.Attribute(H.Val);
        }

        private static int GetIntForMetrics(XElement metricsXml, XName xName)
        {
            var ele = metricsXml.Element(xName);
            if (ele == null)
                return 0;
            return (int)ele.Attribute(H.Val);
        }

        private static XmlDocument GetXmlDocumentForMetrics(XElement metricsXml, XName xName)
        {
            var ele = metricsXml.Element(xName);
            if (ele == null)
                return null;
            return (new XDocument(metricsXml.Element(xName))).GetXmlDocument();
        }
    }
}
