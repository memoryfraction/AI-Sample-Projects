namespace LlamaConsoleApp
{
    public class OllamaRequest
    {
        public string model { get; set; } = "";
        public string prompt { get; set; } = "";
        public bool stream { get; set; } = true;
        public Dictionary<string, object>? options { get; set; }
    }

    public class OllamaResponse
    {
        public string response { get; set; } = "";
        public bool done { get; set; }
    }
}
