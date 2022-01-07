namespace WebAPI_CRUD_Operations.Models
{
    public class Response
    {
        /// <summary>
        /// content is object type
        /// if any method need to return object then this property will used
        /// </summary>
        public object Content { get; set; }

        /// <summary>
        /// status is string type
        /// if any message needs to return from method then this property will used
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// if any exception generates while performing any operation
        /// then Error_Message  is used to store and return error 
        /// </summary>
        public string Error_Message { get; set; }
    }
}