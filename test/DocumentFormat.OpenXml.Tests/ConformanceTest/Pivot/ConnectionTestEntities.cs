// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.IO;
using System.Linq;
using Xunit;

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
                if (x15connection is null)
                {
                    throw new Exception("Unable to obtain the X15.Connection.");
                }

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

        internal void VerifyConnection(Stream stream, ITestOutputHelper log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().Where(e => e.Descendants<X15.OleDbPrpoperties>().Any()).First();
                Assert.True(connection is not null, "Unable to obtain the X15.Connection");

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;
                Assert.True(oleDbPrpoperties is not null, "Unable to obtain the X15.OleDbPrpoperties");

                X15.DbTables dbTables = oleDbPrpoperties.DbTables;

                string connectionString = oleDbPrpoperties.Connection;
                Assert.True(connectionString is not null, "Unable to obtain the X15.OleDbPrpoperties on Connection");

                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                Assert.True(dbCommand is not null, "Unable to obtain the X15.DbCommand");
            }
        }

        internal void EditElement(Stream stream, ITestOutputHelper log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().First();

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;
                oleDbPrpoperties.Connection = ConnectionString;
                log.WriteLine("Edited the OleDbPrpoperties connection");

                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                dbCommand.Text = DBCommandText;
                log.WriteLine("Edited the DbCommand.");
            }
        }

        internal void VerifyElement(Stream stream, ITestOutputHelper log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().First();

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;
                Assert.Equal(ConnectionString, oleDbPrpoperties.Connection);

                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                Assert.Equal(DBCommandText, dbCommand.Text);
            }
        }

        internal void DeleteElement(Stream stream, ITestOutputHelper log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().First();

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;

                oleDbPrpoperties.DbCommand.Remove();
                log.WriteLine("Deleted The DbCommand.");

                oleDbPrpoperties.Remove();
                log.WriteLine("Deleted The OleDbPrpoperties.");

                connection.Parent.Parent.Parent.Remove();
                log.WriteLine("Deleted The Connection.");
            }
        }

        internal void VerifyDeletedElement(Stream stream, ITestOutputHelper log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, false))
            {
                bool hasConnection = false;
                foreach (Connection connection in package.WorkbookPart.ConnectionsPart.Connections)
                {
                    if (connection.Id == 1)
                    {
                        hasConnection = true;
                    }
                }

                Assert.False(hasConnection, "Connection is not delete.");
            }
        }

        internal void AddElement(Stream stream, ITestOutputHelper log)
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
                log.WriteLine("Added the X15.Connection.");

                connectionExtensionList.AppendChild<ConnectionExtension>(connectionExtension);
                log.WriteLine("Added the ConnectionExtension.");

                connection.AppendChild<ConnectionExtensionList>(connectionExtensionList);
                log.WriteLine("Added the ConnectionExtensionList.");

                package.WorkbookPart.ConnectionsPart.Connections.Append(connection);
                log.WriteLine("Added the Connection.");
            }
        }

        internal void VerifyAddedElement(Stream stream, ITestOutputHelper log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(stream, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;

                X15.Connection connection = null;

                foreach (X15.Connection x15connection in connectionsPart.Connections.Descendants<X15.Connection>())
                {
                    if (x15connection.OleDbPrpoperties is not null)
                    {
                        connection = x15connection;
                    }
                }

                Assert.True(connection.OleDbPrpoperties is not null, "Missing X15.OleDbPrpoperties element.");
                Assert.Equal(ConnectionString, connection.OleDbPrpoperties.Connection);

                Assert.True(connection.OleDbPrpoperties is not null, "Missing X15.DbCommand element.");
                Assert.Equal(DBCommandText, connection.OleDbPrpoperties.DbCommand.Text);
            }
        }
    }
}
