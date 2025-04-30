using LibDemo4;
namespace LibDemo3
{
    public class LibClass3
    {
        private string _message;
        public LibClass3(string message) 
        {
            _message = Lib(message);
        }
		
		static string Lib(string txt)
		{
			LibClass4 Lib = new LibClass4(txt);
			return Lib.GetMessage4();			
		}
		
        public string GetMessage3()
        {
            return $"{_message} and from Library3";
        }
    }
}
