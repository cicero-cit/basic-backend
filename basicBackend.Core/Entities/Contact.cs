using System;

namespace basicBackend.Core.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Emoji { get; set; }
    }
}