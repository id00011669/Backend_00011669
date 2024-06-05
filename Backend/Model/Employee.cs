﻿namespace Backend.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Job { get; set; }
        public int Salary { get; set; }
    }
}
