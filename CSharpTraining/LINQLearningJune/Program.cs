

// Language Integrated Query

/*
 In-memory: data/memory stored in Collection List<>, Dictionary<>, Array<> linq on these in memory sources
Output is IEnumerable

 Out-Memory: databases or outsources 
Output of LINQ on Outmemory is IQueryable
 
 */

//LINQ Providers:
/*
 --LINQ to Objects: In memory sources
--LING to entites: process data in external databases and modeled with ORMS
 --LINQ to XML: but that common anymore

Object Relational Mapping: connections the ASP.Net Application to SQL SErver without any "impendance mismatch"
//ORMS needs needs providers they are connection that will connect your LINQ to SQL server.

Extension methods: Where, Orderby, Select, Single, First...
Lambda functions/Delegates 
Linq query Comprehensive syntax (optional): is similar to SQL query syntax to use LINQ.
 */


using LINQLearningJune;

ManageEmployees man = new ManageEmployees();
man.Run();