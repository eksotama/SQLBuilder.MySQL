using System;
using System.Collections.Generic;

namespace SQLBuilder.MySQL {
    /// <summary>
    /// Connection String Class
    /// </summary>
    public class ConnectionString {
        #region Public Properties
        /// <summary>
        /// When true, multiple SQL statements can be sent with one command execution.
        /// </summary>
        public bool AllowBatch { get; set; }

        /// <summary>
        /// Setting this to true indicates that the provider expects user variables in the SQL.
        /// </summary>
        public bool AllowUserVariables { get; set; }

        /// <summary>
        /// If set to True, MySqlDataReader.GetValue() returns a MySqlDateTime object for date or datetime columns
        /// that have disallowed values, such as zero datetime values, and a System.DateTime object for valid
        /// values. If set to False (the default setting) it causes a System.DateTime object to be returned for
        /// all valid values and an exception to be thrown for disallowed values, such as zero datetime values.
        /// </summary>
        public bool AllowZeroDateTime { get; set; }

        /// <summary>
        /// If AutoEnlist is set to true, which is the default, a connection opened using TransactionScope
        /// participates in this scope, it commits when the scope commits and rolls back if TransactionScope does
        /// not commit. However, this feature is considered security sensitive and therefore cannot be used in a
        /// medium trust environment.
        /// </summary>
        public bool AutoEnlist { get; set; }

        /// <summary>
        /// A POSIX-style regular expression that matches the names of BLOB columns that do not contain UTF-8
        /// character data.
        /// </summary>
        public string BlobAsUTF8ExcludePattern { get; set; }

        /// <summary>
        /// A POSIX-style regular expression that matches the names of BLOB columns containing UTF-8 character
        /// data.
        /// </summary>
        public string BlobAsUTF8IncludePattern { get; set; }

        /// <summary>
        /// This option specifies the path to a certificate file in PKCS #12 format (.pfx).
        /// </summary>
        public string CertificateFile { get; set; }

        /// <summary>
        /// Specifies a password that is used in conjunction with a certificate specified using the option
        /// CertificateFile.
        /// </summary>
        public string CertificatePassword { get; set; }

        /// <summary>
        /// Enables you to access a certificate held in a personal store, rather than use a certificate
        /// file and password combination.
        /// </summary>
        public string CertificateStoreLocation { get; set; }

        /// <summary>
        /// Specifies a certificate thumbprint to ensure correct identification of a certificate contained within
        /// a personal store.
        /// </summary>
        public string CertificateThumbprint { get; set; }

        /// <summary>
        /// Specifies the character set that should be used to encode all queries sent to the server. Resultsets
        /// are still returned in the character set of the result data.
        /// </summary>
        public string CharacterSet { get; set; }

        /// <summary>
        /// Indicates if stored routine parameters should be checked against the server.
        /// </summary>
        public bool CheckParameters { get; set; }

        /// <summary>
        /// The list of interceptors that can intercept SQL command operations.
        /// </summary>
        public string CommandInterceptors { get; set; }

        /// <summary>
        /// The length of time (in seconds) to wait for a connection to the server before terminating the attempt
        /// and generating an error.
        /// </summary>
        public uint ConnectionTimeout { get; set; }

        /// <summary>
        /// Passes a predefined set of key/value pairs containing connection-specific data items to the server,
        /// for application-defined purposes. connector/Net automatically transmits the following attributes:
        /// _pid, _client_version, _platform, _program_name, _os, _os_details, and _thread. 
        /// </summary>
        public string ConnectAttrs { get; set; }

        /// <summary>
        /// True to have MySqlDataReader.GetValue() and MySqlDataReader.GetDateTime() return DateTime.MinValue for
        /// date or datetime columns that have disallowed values.
        /// </summary>
        public bool ConvertZeroDateTime { get; set; }

        /// <summary>
        /// Sets the default value of the command timeout to be used. This does not supersede the individual
        /// command timeout property on an individual command object. If you set the command timeout property,
        /// that will be used. 
        /// </summary>
        public uint DefaultCommandTimeout { get; set; }

        /// <summary>
        /// Specifies how long a TableDirect result should be cached, in seconds.
        /// </summary>
        public uint DefaultTableCacheAge { get; set; }

        /// <summary>
        /// When set to true, causes the session-expiry scanner to raise the session_end event before deleting the
        /// session data stored in the my_aspnet_sessions table, when a session times out. Enable this option to
        /// write additional application-specific cleanup code to handle the session_end event of the global.asax
        /// class, before the stored data of the session gets deleted. Within the session_end method, any other
        /// required cleanup can be done.
        /// </summary>
        public bool EnableSessionExpireCallback { get; set; }

        /// <summary>
        /// For Connector/Net 5.0.3 and later, when true, SSL encryption is used for all data sent between the
        /// client and server if the server has a certificate installed.
        /// </summary>
        public bool UseSSL { get; set; }

        /// <summary>
        /// The list of interceptors that can triage thrown MySqlException exceptions.
        /// </summary>
        public string ExceptionInterceptors { get; set; }

        /// <summary>
        /// Causes the connector to return binary/varbinary values as strings, if they do not have a tablename in
        /// the metadata.
        /// </summary>
        public bool FunctionsReturnString { get; set; }

        /// <summary>
        /// The name or network address of the instance of MySQL to which to connect. Multiple hosts can be
        /// specified separated by commas. This can be useful where multiple MySQL servers are configured for
        /// replication and you are not concerned about the precise server you are connecting to. No attempt is
        /// made by the provider to synchronize writes to the database, so take care when using this option. In
        /// Unix environment with Mono, this can be a fully qualified path to a MySQL socket file. With thi
        /// s configuration, the Unix socket is used instead of the TCP/IP socket. Currently, only a single socket
        /// name can be given, so accessing MySQL in a replicated environment using Unix sockets is not currently
        /// supported.
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// When true, instructs the provider to ignore any calls to MySqlCommand.Prepare(). This option is
        /// provided to prevent issues with corruption of the statements when used with server-side prepared
        /// statements. If you use server-side prepare statements, set this option to false. 
        /// </summary>
        public bool IgnorePrepare { get; set; }

        /// <summary>
        /// Must be set to true when using the MySQLClientPermissions class in a partial trust environment,
        /// with the library installed in the GAC of the hosting environment.
        /// </summary>
        public bool IncludeSecurityAsserts { get; set; }

        /// <summary>
        /// The case-sensitive name of the database to use initially.
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// If set to true, the client is interactive. An interactive client is one where the server variable
        /// CLIENT_INTERACTIVE is set. If an interactive client is set, the wait_timeout variable is set to the
        /// value of interactive_timeout. The client will then time out after this period of inactivity.
        /// </summary>
        public bool InteractiveSession { get; set; }

        /// <summary>
        /// Use Windows authentication when connecting to server. By default, it is turned off.
        /// </summary>
        public bool IntegratedSecurity { get; set; }

        /// <summary>
        /// For TCP connections, idle connection time measured in seconds, before the first keepalive packet is
        /// sent. A value of 0 indicates that keepalive is not used.
        /// </summary>
        public uint KeepAlive { get; set; }

        /// <summary>
        /// When true, various pieces of information is output to any configured TraceListeners.
        /// </summary>
        public bool Logging { get; set; }

        /// <summary>
        /// This option was introduced in Connector/Net 6.1.1. The backend representation of a GUID type was
        /// changed from BINARY(16) to CHAR(36). This was done to allow developers to use the server function
        /// UUID() to populate a GUID table - UUID() generates a 36-character string. Developers of older
        /// applications can add 'Old Guids=true' to the connection string to use a GUID of data type BINARY(16).
        /// </summary>
        public bool OldGuids { get; set; }

        /// <summary>
        /// This option was deprecated in Connector/Net 5.2.2. All code should now be written using the '@' symbol
        /// as the parameter marker.
        /// </summary>
        public bool UseOldSyntax { get; set; }

        /// <summary>
        /// The password for the MySQL account being used.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// When set to false or no (strongly recommended), security-sensitive information, such as the password,
        /// is not returned as part of the connection if the connection is open or has ever been in an open state.
        /// Resetting the connection string resets all connection string values, including the password.
        /// </summary>
        public bool PersistSecurityInfo { get; set; }

        /// <summary>
        /// When set to the name of a named pipe, the MySqlConnection attempts to connect to MySQL on that named
        /// pipe. This setting only applies to the Windows platform.
        /// </summary>
        public string PipeName { get; set; }

        /// <summary>
        /// The port MySQL is using to listen for connections. This value is ignored if Unix socket is used.
        /// </summary>
        public uint Port { get; set; }

        /// <summary>
        /// Sets the size of the stored procedure cache. By default, Connector/Net stores the metadata
        /// (input/output data types) about the last 25 stored procedures used. To disable the stored procedure
        /// cache, set the value to zero (0).
        /// </summary>
        public uint ProcedureCacheSize { get; set; }

        /// <summary>
        /// Specifies the type of connection to make to the server. Values can be: socket or tcp for a socket
        /// connection, pipe for a named pipe connection, unix for a Unix socket connection, memory to use MySQL
        /// shared memory.
        /// </summary>
        public ConnectionProtocols ConnectionProtocol { get; set; }

        /// <summary>
        /// Indicates if this connection is to use replicated servers.
        /// </summary>
        public bool Replication { get; set; }

        /// <summary>
        /// Setting this option to false means that Connector/Net ignores a column's binary flags as set by the
        /// server.
        /// </summary>
        public bool RespectBinaryFlags { get; set; }

        /// <summary>
        /// The name of the shared memory object to use for communication if the connection protocol is set to
        /// memory.
        /// </summary>
        public string SharedMemoryName { get; set; }

        /// <summary>
        /// Allow SQL Server syntax. When set to true, enables Connector/Net to support square brackets around
        /// symbols instead of backticks. This enables Visual Studio wizards that bracket symbols with [] to work
        /// with Connector/Net. This option incurs a performance hit, so should only be used if necessary.
        /// </summary>
        public bool SqlServerMode { get; set; }

        /// <summary>
        /// This option has the following values:
        /// <list type="bullet">
        /// <item>
        /// <term>None</term>
        /// <description>do not use SSL.</description>
        /// </item>
        /// <item>
        /// <term>Preferred</term>
        /// <description>use SSL if the server supports it, but allow connection in all cases.</description>
        /// </item>
        /// <item>
        /// <term>Required</term>
        /// <description>Always use SSL. Deny connection if server does not support SSL.</description>
        /// </item>
        /// <item>
        /// <term>VerifyCA</term>
        /// <description>Always use SSL. Validate the CA but tolerate name mismatch.</description>
        /// </item>
        /// <item>
        /// <term>VerifyFull</term>
        /// <description>Always use SSL. Fail if the host name is not correct.</description>
        /// </item>
        /// </list>
        /// </summary>
        public SslModes SslMode { get; set; }

        /// <summary>
        /// Enables or disables caching of TableDirect commands. A value of true enables the cache while false
        /// disables it.
        /// </summary>
        public bool TableCaching { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool TreatBlobsAsUTF8 { get; set; }

        /// <summary>
        /// Setting this value to false causes TINYINT(1) to be treated as an INT.
        /// </summary>
        public bool TreatTinyAsBoolean { get; set; }

        /// <summary>
        /// When true, the connection reports changed rows instead of found rows.
        /// </summary>
        public bool UseAffectedRows { get; set; }

        /// <summary>
        /// When set to true, the default value, MySQL Connector/Net expects the body of the procedure to be
        /// viewable. This enables it to determine the parameter types and order. Set the option to false when the
        /// user connecting to the database does not have the SELECT privileges for the mysql.proc
        /// (stored procedures) table, or cannot view INFORMATION_SCHEMA.ROUTINES. In this case, MySQL
        /// Connector/Net cannot determine the types and order of the parameters, and must be alerted to this fact
        /// by setting this option to false. When set to false, MySQL Connector/Net does not rely on thi
        /// s information being available when the procedure is called. Because MySQL Connector/Net will not be
        /// able to determine this information, explicitly set the types of all the parameters before the call and
        /// add the parameters to the command in the same order as they appear in the procedure definition.
        /// </summary>
        public bool UseProcedureBodies { get; set; }

        /// <summary>
        /// The MySQL login account being used.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Setting this option to true enables compression of packets exchanged between the client and the
        /// server. This exchange is defined by the MySQL client/server protocol.
        /// 
        /// Compression is used if both client and server support ZLIB compression, and the client has requested
        /// compression using this option.
        /// 
        /// A compressed packet header is: packet length (3 bytes), packet number (1 byte), and Uncompressed
        /// Packet Length (3 bytes). The Uncompressed Packet Length is the number of bytes in the original,
        /// uncompressed packet. If this is zero, the data in this packet has not been compressed. When the
        /// compression protocol is in use, either the client or the server may compress packets. However,
        /// compression will not occur if the compressed length is greater than the original length. Thus, some
        /// packets will contain compressed data while other packets will not.
        /// </summary>
        public bool UseCompression { get; set; }

        /// <summary>
        /// Logs inefficient database operations.
        /// </summary>
        public bool UseUsageAdvisor { get; set; }

        /// <summary>
        /// Indicates that performance counters should be updated during execution.
        /// </summary>
        public bool UsePerformanceMonitor { get; set; }

        /// <summary>
        /// Specifies whether server variable settings are updated by a SHOW VARIABLES command each time a pooled
        /// connection is returned. Enabling this setting speeds up connections in a connection pool environment.
        /// Your application is not informed of any changes to configuration variables made by other connections.
        /// </summary>
        public bool CacheServerProperties { get; set; }

        /// <summary>
        /// When a connection is returned to the pool, its creation time is compared with the current time, and
        /// the connection is destroyed if that time span (in seconds) exceeds the value specified by Connection
        /// Lifetime. This is useful in clustered configurations to force load balancing between a running server
        /// and a server just brought online. A value of zero (0) causes pooled connections to have the maximum
        /// connection timeout.
        /// </summary>
        public uint ConnectionLifeTime { get; set; }

        /// <summary>
        /// If true, the connection state is reset when it is retrieved from the pool. The default value of false
        /// avoids making an additional server round trip when obtaining a connection, but the connection state is
        /// not reset.
        /// </summary>
        public bool ConnectionReset { get; set; }

        /// <summary>
        /// The maximum number of connections allowed in the pool.
        /// </summary>
        public uint MaximumPoolsize { get; set; }

        /// <summary>
        /// The minimum number of connections allowed in the pool.
        /// </summary>
        public uint MinimumPoolSize { get; set; }

        /// <summary>
        /// When true, the MySqlConnection object is drawn from the appropriate pool, or if necessary, is created
        /// and added to the appropriate pool.
        /// </summary>
        public bool Pooling { get; set; }
        #endregion

        #region Public Override Method
        /// <summary>
        /// Generates the connection string.
        /// </summary>
        /// <returns>The connection string.</returns>
        public override string ToString() {
            List<string> lstConnections = new List<string>();
            if (!this.AllowBatch) {
                lstConnections.Add("AllowBatch=false");
            }
            if (this.AllowUserVariables) {
                lstConnections.Add("AllowUserVariables=true");
            }
            if (this.AllowZeroDateTime) {
                lstConnections.Add("AllowZeroDateTime=true");
            }
            if (!this.AutoEnlist) {
                lstConnections.Add("AutoEnlist=false");
            }
            if (!this.BlobAsUTF8ExcludePattern.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("BlobAsUTF8ExcludePattern={0}", this.BlobAsUTF8ExcludePattern));
            }
            if (!this.BlobAsUTF8IncludePattern.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("BlobAsUTF8IncludePattern={0}", this.BlobAsUTF8IncludePattern));
            }
            if (!this.CertificateFile.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("CertificateFile={0}", this.CertificateFile));
            }
            if (!this.CertificatePassword.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("CertificatePassword={0}", this.CertificatePassword));
            }
            if (!this.CertificateStoreLocation.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("CertificateStoreLocation={0}", this.CertificateStoreLocation));
            }
            if (!this.CertificateThumbprint.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("CertificateThumbprint={0}", this.CertificateThumbprint));
            }
            if (!this.CharacterSet.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("CharacterSet={0}", this.CharacterSet));
            }
            if (!this.CheckParameters) {
                lstConnections.Add("CheckParameters=false");
            }
            if (!this.CommandInterceptors.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("CommandInterceptors={0}", this.CommandInterceptors));
            }
            if (this.ConnectionTimeout != 15) {
                lstConnections.Add(String.Format("ConnectionTimeout={0}", this.ConnectionTimeout));
            }
            if (!this.ConnectAttrs.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("Connect_Attrs={0}", this.ConnectAttrs));
            }
            if (this.ConvertZeroDateTime) {
                lstConnections.Add("ConvertZeroDateTime=true");
            }
            if (this.DefaultCommandTimeout != 30) {
                lstConnections.Add(String.Format("DefaultCommandTimeout={0}", this.DefaultCommandTimeout));
            }
            if (this.DefaultTableCacheAge != 60) {
                lstConnections.Add(String.Format("DefaultTableCacheAge={0}", this.DefaultTableCacheAge));
            }
            if (this.EnableSessionExpireCallback) {
                lstConnections.Add("enableSessionExpireCallback=true");
            }
            if (this.UseSSL) {
                lstConnections.Add("UseSSL=true");
            }
            if (!this.ExceptionInterceptors.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("ExceptionInterceptors={0}", this.ExceptionInterceptors));
            }
            if (this.FunctionsReturnString) {
                lstConnections.Add("FunctionsReturnString=true");
            }
            if (!this.Host.IsNullOrWhiteSpace() && !this.Host.Equals("localhost")) {
                lstConnections.Add(String.Format("Host={0}", this.Host));
            }
            if (!this.IgnorePrepare) {
                lstConnections.Add("IgnorePrepare=false");
            }
            if (this.IncludeSecurityAsserts) {
                lstConnections.Add("includesecurityasserts=true");
            }
            if (!this.Database.IsNullOrWhiteSpace() && !this.Database.Equals("mysql")) {
                lstConnections.Add(String.Format("Database={0}", this.Database));
            }
            if (this.InteractiveSession) {
                lstConnections.Add("InteractiveSession=true");
            }
            if (this.IntegratedSecurity) {
                lstConnections.Add("IntegratedSecurity=yes");
            }
            if (this.KeepAlive != 0) {
                lstConnections.Add(String.Format("Keepalive={0}", this.KeepAlive));
            }
            if (this.Logging) {
                lstConnections.Add("Logging=true");
            }
            if (this.OldGuids) {
                lstConnections.Add("OldGuids=true");
            }
            if (this.UseOldSyntax) {
                lstConnections.Add("UseOldSyntax=true");
            }
            if (!this.Password.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("Password={0}", this.Password));
            }
            if (this.PersistSecurityInfo) {
                lstConnections.Add("PersistSecurityInfo=true");
            }
            if (!this.PipeName.IsNullOrWhiteSpace() && !this.PipeName.Equals("mysql")) {
                lstConnections.Add(String.Format("PipeName={0}", this.PipeName));
            }
            if (this.Port != 3306) {
                lstConnections.Add(String.Format("Keepalive={0}", this.Port));
            }
            if (this.ProcedureCacheSize != 25) {
                lstConnections.Add(String.Format("ProcedureCacheSize={0}", this.ProcedureCacheSize));
            }
            if (this.ConnectionProtocol != ConnectionProtocols.Socket) {
                switch (this.ConnectionProtocol) {
                    case ConnectionProtocols.TCP:
                        lstConnections.Add("ConnectionProtocol=tcp");
                        break;
                    case ConnectionProtocols.Pipe:
                        lstConnections.Add("ConnectionProtocol=pipe");
                        break;
                    case ConnectionProtocols.Unix:
                        lstConnections.Add("ConnectionProtocol=unix");
                        break;
                    case ConnectionProtocols.Memory:
                        lstConnections.Add("ConnectionProtocol=memory");
                        break;
                }
            }
            if (this.Replication) {
                lstConnections.Add("Replication=true");
            }
            if (!this.RespectBinaryFlags) {
                lstConnections.Add("RespectBinaryFlags=false");
            }
            if (!this.SharedMemoryName.IsNullOrWhiteSpace() && !this.SharedMemoryName.Equals("MYSQL")) {
                lstConnections.Add(String.Format("SharedMemoryName={0}", this.SharedMemoryName));
            }
            if (this.SqlServerMode) {
                lstConnections.Add("sqlservermode=true");
            }
            if (this.SslMode != SslModes.None) {
                switch (this.SslMode) {
                    case SslModes.Preferred:
                        lstConnections.Add("SslMode=Preferred");
                        break;
                    case SslModes.Required:
                        lstConnections.Add("SslMode=Required");
                        break;
                    case SslModes.VerifyCA:
                        lstConnections.Add("SslMode=VerifyCA");
                        break;
                    case SslModes.VerifyFull:
                        lstConnections.Add("SslMode=VerifyFull ");
                        break;
                }
            }
            if (this.TableCaching) {
                lstConnections.Add("tablecaching=true");
            }
            if (this.TreatBlobsAsUTF8) {
                lstConnections.Add("TreatBlobsAsUTF8=true");
            }
            if (!this.TreatTinyAsBoolean) {
                lstConnections.Add("TreatTinyAsBoolean=false");
            }
            if (this.UseAffectedRows) {
                lstConnections.Add("UseAffectedRows=true");
            }
            if (!this.UseProcedureBodies) {
                lstConnections.Add("UseProcedureBodies=false");
            }
            if (!this.Username.IsNullOrWhiteSpace()) {
                lstConnections.Add(String.Format("Username={0}", this.Username));
            }
            if (this.UseCompression) {
                lstConnections.Add("UseCompression=true");
            }
            if (this.UseUsageAdvisor) {
                lstConnections.Add("UseUsageAdvisor=true");
            }
            if (this.UsePerformanceMonitor) {
                lstConnections.Add("UsePerformanceMonitor=true");
            }
            if (this.CacheServerProperties) {
                lstConnections.Add("CacheServerProperties=true");
            }
            if (this.ConnectionLifeTime != 0) {
                lstConnections.Add(String.Format("ConnectionLifeTime={0}", this.ConnectionLifeTime));
            }
            if (this.ConnectionReset) {
                lstConnections.Add("ConnectionReset=true");
            }
            if (this.MaximumPoolsize != 100) {
                lstConnections.Add(String.Format("MaximumPoolsize={0}", this.MaximumPoolsize));
            }
            if (this.MinimumPoolSize != 0) {
                lstConnections.Add(String.Format("MinimumPoolSize={0}", this.MaximumPoolsize));
            }
            if (!this.Pooling) {
                lstConnections.Add("Pooling=false");
            }
            return String.Join(";", lstConnections.ToArray());
        }
        #endregion
    }
}
