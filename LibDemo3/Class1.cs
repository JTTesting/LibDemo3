namespace LibDemo3
{
    public class LibClass3
    {
        private string _message;
        public LibClass3(string message) 
        {
            _message = message;
        }
        public string GetMessage()
        {
            return $"{_message} from Library3";
        }
    }
}
