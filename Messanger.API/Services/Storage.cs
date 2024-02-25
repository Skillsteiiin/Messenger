namespace Messanger.API.Services
{
    public class Storage
    {
        private List<Message> Messages{ get; set; }

        public async Task LoadMessages(string[] input)
        {
            Messages = new List<Message>();
        }
        private Message Parse (string input)
        {
            return new();
        }
    }
    

    public class Message
    {
        public int Id { get; set; }

    }
}
