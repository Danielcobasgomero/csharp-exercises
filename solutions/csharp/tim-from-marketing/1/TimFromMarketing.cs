static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idNumber = id?.ToString() != null ? $"[{id}] -" : "";
        string ownerDepartment = department ?? "owner";
        return $"{idNumber} {name} - {ownerDepartment.ToUpper()}".Trim();
    }
}
