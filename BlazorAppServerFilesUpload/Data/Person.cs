using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppServerFilesUpload.Data
{
    public class Person
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]

        public IBrowserFile[] Picture { get; set; }
    }
}
