// Copyright (c) Microsoft Open Technologies, Inc.  All rights reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocumentFormat.OpenXml.Tests.Pivot
{
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Spreadsheet;
    using X15 = DocumentFormat.OpenXml.Office2013.Excel;
    using LogUtil;

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

        public ConnectionTestEntities(string filePath)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                foreach (Connection connection in connectionsPart.Connections)
                {
                    if (connection.Id == 1)
                    {
                        this.ConnectionId = connection.Id;
                        this.ConnectionOdcFile = connection.ConnectionFile;
                        this.ConnectionName = connection.Name;
                        this.ConnectionType = connection.Type;
                        this.ConnectionRefreshedVersion = connection.RefreshedVersion;
                        this.ConnectionMinRefreshedVersion = connection.MinRefreshableVersion;
                        this.ConnectionBackground = connection.Background;
                    }
                }

                X15.Connection x15connection = connectionsPart.Connections.Descendants<X15.Connection>().FirstOrDefault();
                if (x15connection == null)
                    throw new Exception("Unable to obtain the X15.Connection.");

                this.X15ConnectionId = x15connection.Id;
                this.X15ConnectionAutoDelete = x15connection.AutoDelete;

                ConnectionExtension connectionExtension = new ConnectionExtension(x15connection.Parent.OuterXml);
                this.ConnectionExtUri = connectionExtension.Uri;

                X15.OleDbPrpoperties oleDbPrpoperties = x15connection.OleDbPrpoperties;
                this.ConnectionString = oleDbPrpoperties.Connection;
                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                this.DBCommandText = dbCommand.Text;
            }
        }

        public void VerifyConnection(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
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

        public void EditElement(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().First();

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;
                oleDbPrpoperties.Connection = this.ConnectionString;
                log.Pass("Edited the OleDbPrpoperties connection");

                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                dbCommand.Text = this.DBCommandText;
                log.Pass("Edited the DbCommand.");
            }
        }

        public void VerifyElement(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                X15.Connection connection = connectionsPart.Connections.Descendants<X15.Connection>().First();

                X15.OleDbPrpoperties oleDbPrpoperties = connection.OleDbPrpoperties;
                log.Verify(oleDbPrpoperties.Connection == this.ConnectionString, "OleDbPrpoperties Connection value is not change.");

                X15.DbCommand dbCommand = oleDbPrpoperties.DbCommand;
                log.Verify(this.DBCommandText == dbCommand.Text, "DBCommandText value is not change.");
            }
        }

        public void DeleteElement(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true))
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

        public void VerifyDeletedElement(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, false))
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

        public void AddElement(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;
                int connectionNum = connectionsPart.Connections.Descendants<X15.Connection>().Count();

                X15.Connection x15connection = new X15.Connection() { Id = this.X15ConnectionId, AutoDelete = this.X15ConnectionAutoDelete };
                x15connection.OleDbPrpoperties = new X15.OleDbPrpoperties() { Connection = this.ConnectionString };
                x15connection.OleDbPrpoperties.DbCommand = new X15.DbCommand() { Text = this.DBCommandText };

                ConnectionExtension connectionExtension = new ConnectionExtension() { Uri = this.ConnectionExtUri };
                Connection connection = new Connection() { Id = this.ConnectionId, ConnectionFile = this.ConnectionOdcFile, Name = this.ConnectionName, Type = this.ConnectionType, RefreshedVersion = this.ConnectionRefreshedVersion, MinRefreshableVersion = this.ConnectionMinRefreshedVersion, Background = this.ConnectionBackground };
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

        public void VerifyAddedElement(string filePath, VerifiableLog log)
        {
            using (SpreadsheetDocument package = SpreadsheetDocument.Open(filePath, true))
            {
                ConnectionsPart connectionsPart = package.WorkbookPart.ConnectionsPart;

                X15.Connection connection = null;

                foreach (X15.Connection x15connection in connectionsPart.Connections.Descendants<X15.Connection>())
                {
                    if (x15connection.OleDbPrpoperties != null)
                        connection = x15connection;
                }

                log.Verify(connection.OleDbPrpoperties != null, "Missing X15.OleDbPrpoperties element.");
                log.Verify(connection.OleDbPrpoperties.Connection == this.ConnectionString, "OleDbPrpoperties Connection value is not change.");

                log.Verify(connection.OleDbPrpoperties != null, "Missing X15.DbCommand element.");
                log.Verify(connection.OleDbPrpoperties.DbCommand.Text == this.DBCommandText, "OleDbPrpoperties Connection value is not change.");
            }
        }
    }
}
