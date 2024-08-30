namespace TelefonbuchXml
{
    [Serializable]
    public class Person
    {
        public string? Vorname { get; set; }
        public string? Name { get; set; }
        public string? Telefon { get; set; }
        public string? Email { get; set; }

        public Person() { }

        public Person(string vorname, string name, string telefon, string email)
        {
            Vorname = vorname;
            Name = name;
            Telefon = telefon;
            Email = email;
        }
    }
}