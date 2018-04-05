// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using LogUtil;
using System;
using System.IO;
using System.Linq;

using X15 = DocumentFormat.OpenXml.Office2013.Excel;

namespace DocumentFormat.OpenXml.Tests.Pivot
{
    public class ConnectionTestEntities
    {
        private string ConnectionString { get; set; }

        private string DBCommandText { get; set; }

        private string ConnectionExtUri { get; set; }

        private uint ConnectionId { get; set; }

        private string ConnectionOdcFile { get; set; }

        private string ConnectionName { get; set; }

        private uint ConnectionType { get; set; }

        private byte ConnectionRefreshedVersion { get; set; }

        private byte ConnectionMinRefreshedVersion { get; set; }

        private bool ConnectionBackground { get; set; }

        private string X15ConnectionId { get; set; }

        private bool X15ConnectionAutoDelete { get; set; }

        public ConnectionTestEntities(Stream stream)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                foreach (Connection connection in connectionsPart.Connections)
                {
                    if (connection.Id == 1)
                    {
                        ConnectionId = connection.Id;
                        ConnectionOdcFile = connection.ConnectionFile;
                        ConnectionName = connection.Name;
                        ConnectionType = connection.Type;
                        ConnectionRefreshedVersion = connection.RefreshedVersion;
                        ConnectionMinRefreshedVersion = connection.MinRefreshableVersion;
                        ConnectionBackground = connection.Background;
                    }
                }

                X15.Connection x15connection = connectionsPart.Connections.Descendants<X15.Connection>().FirstOrDefault();
                if (x15connection == null)
                    throw new Exception("Unable to obtain the X15.Connection.");

                X15ConnectionId = x15connection.Id;
                X15ConnectionAutoDelete = x15connection.AutoDelete;

                ConnectionExtension connectionExtension = new ConnectionExtension(x15connection.Parent.OuterXml);
                ConnectionExtUri = connectionExtension.Uri;

                X15.OleDbPrpoperties oleDbPrpoperties = x15connection.OleDbPrpoperties;
                ConnectionString = oleDbPrpoperties.Connection;
                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                DBCommandText = dbCommand.Text;
            }
        }

        public void VerifyConnection(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().Where(e => e.Descendants<X15.OleDbPrpoperties>().Count() > 0).First();
                log.Verify(connection != null, "Unable to obtain the X15.Connection");

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;
                log.Verify(oleDbPrpoperties != null, "Unable to obtain the X15.OleDbPrpoperties");

                X15.DbTables dbTables = oleDbPrpoperties.DbTables;

                string connectionString = oleDbPrpoperties.Connection;
                log.Verify(connectionString != null, "Unable to obtain the X15.OleDbPrpoperties on Connection");

                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                log.Verify(dbCommand != null, "Unable to obtain the X15.DbCommand");
            }
        }

        public void EditElement(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().First();

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;
                oleDbPrpoperties.Connection = ConnectionString;
                log.Pass("Edited the OleDbPrpoperties connection");

                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                dbCommand.Text = DBCommandText;
                log.Pass("Edited the DbCommand.");
            }
        }

        public void VerifyElement(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().First();

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;
                log.Verify(oleDbPrpoperties.Connection == ConnectionString, "OleDbPrpoperties Connection value is not change.");

                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                log.Verify(DBCommandText == dbCommand.Text, "DBCommandText value is not change.");
            }
        }

        public void DeleteElement(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().First();

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;

                oleDbPrpoperties.DbCommand.Remove();
                log.Pass("Deleted The DbCommand.");

                oleDbPrpoperties.Remove();
                log.Pass("Deleted The OleDbPrpoperties.");

                connection.Parent.Parent.Parent.Remove();
                log.Pass("Deleted The Connection.");
            }
        }

        public void VerifyDeletedElement(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false))
            {
                bool hasConnection = false;
                foreach (Connection connection in package.WorkbookPart.ConnectionsPart.Connections)
                {
                    if (connection.Id == 1)
                        hasConnection = true;
                }

                log.Verify(hasConnection == false, "Connection is not delete.");
            }
        }

        public void AddElement(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                int connectionNum = connectionsPart.Connections.Descendants<X15.Connection>().Count();

                X15.Connection x15connection = new X15.Connection() { Id = X15ConnectionId, AutoDelete = X15ConnectionAutoDelete };
                x15connection.OleDbPrpoperties = new X15.OleDbPrpoperties() { Connection = ConnectionString };
                x15connection.OleDbPrpoperties.DbCommand = new X15.DbCommand() { Text = DBCommandText };

                ConnectionExtension connectionExtension = new ConnectionExtension() { Uri = ConnectionExtUri };
                Connection connection = new Connection() { Id = ConnectionId, ConnectionFile = ConnectionOdcFile, Name = ConnectionName, Type = ConnectionType, RefreshedVersion = ConnectionRefreshedVersion, MinRefreshableVersion = ConnectionMinRefreshedVersion, Background = ConnectionBackground };
                ConnectionExtensionList connectionExtensionList = new ConnectionExtensionList();

                connectionExtension.AppendChild<X15.Connection>(x15connection);
                log.Pass("Added the X15.Connection.");

                connectionExtensionList.AppendChild<ConnectionExtension>(connectionExtension);
                log.Pass("Added the ConnectionExtension.");

                connection.AppendChild<ConnectionExtensionList>(connectionExtensionList);
                log.Pass("Added the ConnectionExtensionList.");

                package.WorkbookPart.ConnectionsPart.Connections.Append(connection);
                log.Pass("Added the Connection.");
            }
        }

        public void VerifyAddedElement(Stream stream, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;

                X15.Connection connection = null;

                foreach (X15.Connection x15connection in connectionsPart.Connections.Descendants<X15.Connection>())
                {
                    if (x15connection.OleDbPrpoperties != null)
                        connection = x15connection;
                }

                log.Verify(connection.OleDbPrpoperties != null, "Missing X15.OleDbPrpoperties element.");
                log.Verify(connection.OleDbPrpoperties.Connection == ConnectionString, "OleDbPrpoperties Connection value is not change.");

                log.Verify(connection.OleDbPrpoperties != null, "Missing X15.DbCommand element.");
                log.Verify(connection.OleDbPrpoperties.DbCommand.Text == DBCommandText, "OleDbPrpoperties Connection value is not change.");
            }
        }
    }
}
