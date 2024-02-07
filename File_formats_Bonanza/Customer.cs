class Employee
{
    public int UserID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

	public Employee(int UserID, string Name, string Email)
    {
        UserID = UserID;
        Name = Name;
        Email = Email;
    }
}