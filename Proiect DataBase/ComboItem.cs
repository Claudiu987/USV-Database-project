using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStudenti
{
    public class ComboItem
    {
        
        public int Value { get; set; }
        public string Text { get; set; } 

        public ComboItem(string text,int value)
        {
            
            Value = value;
            Text = text;
        }
        public override string ToString()
        {
            return Text;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            // verifica daca obiectul primit ca parametru poate fi convertit la un obiect de tip ComboItem
            ComboItem ci = obj as ComboItem;
            if ((object)ci == null)
            {
                return false;
            }

            // returneaza 'true' daca atat textele cat si valorile celor 2 obiecte sunt identice intre ele
            return ( this.Value == ci.Value && this.Text.Equals(ci.Text));
        }

        public override int GetHashCode()
        {
            return this.Value;
        }
    }
}
