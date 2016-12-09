
namespace SQLBuilder.MySQL {
    /// <summary>
    /// Connection Protocols enum.
    /// </summary>
    public enum ConnectionProtocols {
        /// <summary>
        /// Socket connection.
        /// </summary>
        Socket,
        /// <summary>
        /// Socket connection.
        /// </summary>
        TCP,
        /// <summary>
        /// Named pipe connection.
        /// </summary>
        Pipe,
        /// <summary>
        /// Unix socket connection.
        /// </summary>
        Unix,
        /// <summary>
        /// MySQL shared memory.
        /// </summary>
        Memory
    }

    /// <summary>
    /// Ssl Modes enum.
    /// </summary>
    public enum SslModes {
        /// <summary>
        /// Do not use SSL.
        /// </summary>
        None,
        /// <summary>
        /// Use SSL if the server supports it, but allow connection in all cases.
        /// </summary>
        Preferred,
        /// <summary>
        /// Always use SSL. Deny connection if server does not support SSL.
        /// </summary>
        Required,
        /// <summary>
        /// Always use SSL. Validate the CA but tolerate name mismatch.
        /// </summary>
        VerifyCA,
        /// <summary>
        /// Always use SSL. Fail if the host name is not correct.
        /// </summary>
        VerifyFull
    }

    /// <summary>
    /// Order Directions enum.
    /// </summary>
    public enum OrderDirections {
        /// <summary>
        /// Asc value.
        /// </summary>
        Asc,
        /// <summary>
        /// Desc value.
        /// </summary>
        Desc
    }

    /// <summary>
    /// Connectors enum.
    /// </summary>
    public enum Connectors {
        /// <summary>
        /// AND connector.
        /// </summary>
        And,
        /// <summary>
        /// OR connector.
        /// </summary>
        Or
    }

    /// <summary>
    /// Operators enum.
    /// </summary>
    public enum Operators {
        /// <summary>
        /// IS operator.
        /// </summary>
        Is,
        /// <summary>
        /// IS NOT operator.
        /// </summary>
        IsNot,
        /// <summary>
        /// = operator.
        /// </summary>
        Equal,
        /// <summary>
        /// != operator.
        /// </summary>
        NotEqual,
        /// <summary>
        /// > operator.
        /// </summary>
        GreaterThan,
        /// <summary>
        /// >= operator.
        /// </summary>
        GreaterThanOrEqual,
        /// <summary>
        /// &lt; operator.
        /// </summary>
        LesserThan,
        /// <summary>
        /// &lt;= operator.
        /// </summary>
        LesserThanOrEqual,
        /// <summary>
        /// IN operator.
        /// </summary>
        In,
        /// <summary>
        /// NOT IN operator.
        /// </summary>
        NotIn
    }
}
