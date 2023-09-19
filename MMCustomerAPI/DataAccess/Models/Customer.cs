﻿using System.ComponentModel.DataAnnotations;

namespace DataAccess;

public class Customer
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; }
    [Required]
    public string ForeName { get; set; }
    [Required]
    public string SurName { get; set; }
    [Required]
    public string EmailAddress { get; set; }
    [Required]
    public string MobileNo { get; set; }
    public ICollection<Address> Addresses { get; set; }
}
