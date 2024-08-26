namespace RenderExample.Models
{
    public class Block
    {

        public Block(int id, string type, string content)
        {
            Id= id;
            Type= type;
            Content= content;
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
    }
}
