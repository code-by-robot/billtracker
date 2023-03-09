using RazorPagesBill.Models;
using Microsoft.EntityFrameworkCore;
using RazorPagesBill.Data;

namespace RazorPagesBill.Services;

public class BillService
{
    private readonly BillContext _context;

    public BillService(BillContext context)
    {
        _context = context;
    }

    public IEnumerable<Bill> GetAll()
    {
      return _context.Bills
        .AsNoTracking()
        .ToList();
    }

    public IEnumerable<Bill> GetByState(string State)
    {
     return _context.Bills.Where(p => p.StateName == State).ToList();
    }

    public IEnumerable<Bill> GetByType(string Type)
    {
        return _context.Bills.Where(p => p.BillType == Type).ToList();
    }
    public Bill? GetById(int id)
    {
        var foundBill =_context.Bills.FirstOrDefault(p => p.Id == id);
        return foundBill;
    }
    public Bill Create(Bill newBill)
    {
        _context.Bills.Add(newBill);
        _context.SaveChanges();

        return newBill;
    }

    public void ToggleLaw(int Id)
    {
        
            Bill? WorkingBill = _context.Bills.FirstOrDefault(p => p.Id == Id);
            if (WorkingBill is not null)
            {
                WorkingBill.IsLaw = !WorkingBill.IsLaw;
            }
       _context.SaveChanges();
    }

    public void RemoveBill(Bill oldBill)
    {
        _context.Remove(oldBill);
        _context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        var billToDelete = _context.Bills.Find(id);
        if (billToDelete is not null)
        {
            _context.Bills.Remove(billToDelete);
            _context.SaveChanges();
        }
    }
}
