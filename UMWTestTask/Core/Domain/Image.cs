namespace UMWTestTask.Core.Domain
{
    public class Image
    {
        public int Id { get; set; }

        public byte[] Source { get; set; }

        public Product Product { get; set; }
    }
}
