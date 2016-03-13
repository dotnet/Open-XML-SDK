#### 2.6.1 - January 15, 2016
* Added hundreds of XUnit tests.  There are now a total of 1333 tests.  They take about 20 minutes to run, so be patient.

#### 2.6.0 - June 29, 2015
* The big feature in 2.6 is the inclusion of a replacement for System.IO.Packaging, which 
has a serious bug that causes it (albeit rarely and in specific circumstances)
to throw exceptions (ObjectDisposedException and NullReferenceException).  You can
find out more about this bug and whether it affects you in [the blog post that announces the release of the new System.IO.Packaging](http://openxmldeveloper.org/blog/b/openxmldeveloper/archive/2015/06/29/announcing-the-release-of-a-new-system-io-packaging-implementation.aspx).
