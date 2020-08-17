using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notifies
    {
        public Notifies()
        {
            Notitycoes = new List<Notifies>();
        }

        [NotMapped]
        public string NameProperty { get; set; }
        [NotMapped]
        public string Message { get; set; }
        [NotMapped]
        public List<Notifies> Notitycoes { get; set; }

        public bool CheckPropertyString(string value, string nameProperty)
        {
            if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notitycoes.Add(new Notifies
                { 
                    Message = "This property is required",
                    NameProperty = nameProperty
                });

                return false;
            }

            return true;
        }
        public bool CheckPropertyInt(int value, string nameProperty)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notitycoes.Add(new Notifies
                {
                    Message = "Value can't be 0",
                    NameProperty = nameProperty
                });

                return false;
            }

            return true;
        }
        public bool CheckPropertyDecimal(decimal value, string nameProperty)
        {
            if (value < 1 || string.IsNullOrWhiteSpace(nameProperty))
            {
                Notitycoes.Add(new Notifies
                {
                    Message = "Value can't be 0",
                    NameProperty = nameProperty
                });

                return false;
            }

            return true;
        }
    }
}
