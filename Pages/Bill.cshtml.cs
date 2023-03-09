using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesBill.Models;
using RazorPagesBill.Services;

namespace RazorPagesBill.Pages
{
    public class BillModel : PageModel
    {
        [BindProperty]
        public Bill? NewBill {get; set;}
        public List<Bill> bills = new();
        public void OnGet()
        {
           bills = BillService.GetAll(); 
        }

        public string IsLawText(Bill bill)
        {
            return bill.IsLaw ? "Law Passed": "Still a Bill";
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            BillService.Create(NewBill);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id)
        {
            BillService.DeleteById(id);
            return RedirectToAction("Get");
        }
    }

}
