namespace Tnosc.Laf.Shared.Common
{
    /// <summary>
    /// <para>Encapsulates information regarding the operation’s results</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Instanciate Result class using two parameters
        /// </summary>
        /// <param name="isSuccess">true if the operation has completed without errors; otherwise false</param>
        /// <param name="errors">Errors raised during an operation</param>
        protected Result(bool isSuccess, IEnumerable<string> errors)
        {
            if (isSuccess && errors != null && errors.Any())
                throw new InvalidOperationException();
            if (!isSuccess && errors != null && !errors.Any())
                throw new InvalidOperationException();

            IsSuccess = isSuccess;
            Errors = errors;
        }
        /// <summary>
        /// Gets the raised errors during an operation
        /// </summary>
        public IEnumerable<string> Errors { get; }
        /// <summary>
        /// Gets whether the operation was failed
        /// </summary>
        public bool IsFailure => !IsSuccess;
        /// <summary>
        /// Gets whether the operation was succeeded
        /// </summary>
        public bool IsSuccess { get; }
        /// <summary>
        /// Combine an array of Result object into one instance
        /// </summary>
        /// <param name="results">Array of Result objects</param>
        /// <returns>Result object without error if all Result object are successeded; otherwise Result object with an error(s)</returns>
        public static Result Combine(params Result[] results)
        {
            foreach (Result result in results)
            {
                if (result.IsFailure)
                    return result;
            }

            return Ok();
        }
        /// <summary>
        /// Instanciate a Result object with an error message
        /// </summary>
        /// <param name="message">Error message</param>
        /// <returns>Result object with an error</returns>
        public static Result Fail(string message)
        {
            return Fail(ToStringArray(message));
        }
        /// <summary>
        /// Instanciate a Result object with an array of error message
        /// </summary>
        /// <param name="messages">Array of error message</param>
        /// <returns>Result object with errors</returns>
        public static Result Fail(string[] messages)
        {
            return new Result(false, messages);
        }
        /// <summary>
        /// Instanciate a Result object with a collection of error message
        /// </summary>
        /// <param name="messages">Collection of error message</param>
        /// <returns>Result object with errors</returns>
        public static Result<T> Fail<T>(IEnumerable<string> messages)
        {
            return new Result<T>(default, false, messages);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message"></param>
        /// <returns></returns>
        public static Result<T> Fail<T>(string message)
        {
            return Fail<T>(ToStringArray(message));
        }
        /// <summary>
        /// Instanciate Result object without errors
        /// </summary>
        /// <returns>Result object without errors</returns>
        public static Result Ok()
        {
            return new Result(true, null);
        }
        /// <summary>
        ///  Instanciate Result object without errors with the returned value from the operation
        /// </summary>
        /// <typeparam name="T">Result type</typeparam>
        /// <param name="value">Result value</param>
        /// <returns>Result object without errors with the returned value from the operation</returns>
        public static Result<T> Ok<T>(T value)
        {
            return new Result<T>(value, true, string.Empty);
        }

        protected static string[] ToStringArray(string value)
        {
            if (string.IsNullOrEmpty(value))
                return Array.Empty<string>();
            return new string[] { value };
        }
    }

    /// <summary>
    /// <para>Encapsulates information regarding the operation’s results strongly typed; an error message in case it failed and an object instance in case it succeeded.</para>
    /// <para>Author: Ahmed HEDFI (ahmed.hedfi@gmail.com)</para>
    /// </summary>
    /// <typeparam name="T">Returned value from the operation</typeparam>
    public class Result<T> : Result
    {
        private readonly T _value;
        /// <summary>
        /// Instanicate Result strong typed with three parameters
        /// </summary>
        /// <param name="value">Result value</param>
        /// <param name="isSuccess">true if the operation has completed without errors; otherwise false</param>
        /// <param name="error">Error raised during an operation</param>
        protected internal Result(T value, bool isSuccess, string error)
            : this(value, isSuccess, ToStringArray(error))
        {
        }
        /// <summary>
        /// Instanicate Result strong typed with three parameters
        /// </summary>
        /// <param name="value">Result value</param>
        /// <param name="isSuccess">true if the operation has completed without errors; otherwise false</param>
        /// <param name="errors">Errors raised during an operation</param>
        protected internal Result(T value, bool isSuccess, IEnumerable<string> errors)
           : base(isSuccess, errors)
        {
            _value = value;
        }
        /// <summary>
        /// Gets the Result value of an operation in case it has completed without errors
        /// </summary>
        public T Value
        {
            get
            {
                if (!IsSuccess)
                    throw new InvalidOperationException();

                return _value;
            }
        }
    }
}
