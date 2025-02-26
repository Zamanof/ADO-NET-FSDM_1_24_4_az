using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO_NET_03._Entity_intro;

internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public override string ToString()
    {
        return $@"------------{Id}------------
FirstName:      {FirstName}
LastName:       {LastName}
BirthDay:       {BirthDate.ToShortDateString()}
{new string('-', 26)}";
    }
}
