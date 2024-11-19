namespace ClassApp.Entities
{
    internal partial class Person
    {
        public string Name
        {
            get
            {
                return (_name == "" || _name == null) ? "Empty Name" : _name;
            }
            set
            {
                try
                {
                    if (value == null || value == "")
                    {
                        throw new ArgumentNullException("Name cannot be null or empty");
                    }
                    _name = value;
                }
                catch (ArgumentNullException ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Type: {Type}";
        }
    }
}