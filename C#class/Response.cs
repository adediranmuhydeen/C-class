namespace C_class
{
    public  class Response
    {
        private string _message;
        private bool _success;

        public Response(bool success)
        {
            if(success)
            {
                _message = "Is successful";
            }
            else
            {
                _message = "fail";
            }
        }
    }
}
