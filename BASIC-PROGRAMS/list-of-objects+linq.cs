using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
internal class TechMahindra
{
    internal string empname;
    internal int empid;
    internal string dept;
    internal string doj;
  
    public TechMahindra(string empname,int empid,string dept,string doj)
    {
        this.empname=empname;
        this.empid=empid;
        this.dept=dept;
        this.doj=doj;
    }
}
public class Program
{
  static void Main(string[] args)
  {
        List<TechMahindra> tlist = new List<TechMahindra>();
        tlist.Add(new TechMahindra("Soumen",103,"Math","05-04-2024"));
        tlist.Add(new TechMahindra("Ankita",101,"BPO","05-04-2024"));
        tlist.Add(new TechMahindra("Biswa",102,"IT","05-04-2024"));
        // LINQ Method Syntax
       var res = from s in tlist
                   orderby s.empid
                   select s;
        foreach(TechMahindra techm in res)
        {
            Console.WriteLine("Employee name: "+techm.empname+" Dept: "+techm.dept+" Employee id: "+techm.empid+" DOJ: "+techm.doj);
        }
    
   }
    
}
    




