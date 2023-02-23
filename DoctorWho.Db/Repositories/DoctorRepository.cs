using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository
    {
        private DoctorWhoCoreDbContext _context;
        public DoctorRepository(DoctorWhoCoreDbContext context)
        {
            _context = context;
        }

        public void CreateDoctor(int doctorNumber, string doctornName)
        {
            var doctor = new Doctor { DoctorNumber = doctorNumber, DoctorName = doctornName };
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
        }

        public void DeleteDoctor(string doctorName)
        {
            var doctor = _context.Doctors.Where(x => x.DoctorName == doctorName).FirstOrDefault();
            if (doctor != null)
            {
                _context.Doctors.Remove(doctor);
                _context.SaveChanges();
            }
        }

        public void UpdateDoctor(Doctor doctor)
        {
            _context.Doctors.Update(doctor);
            _context.SaveChanges();
        }

        public List<Doctor> GetAllDoctors()
        {
            var allDoctors = _context.Doctors.ToList();
            return allDoctors;
        }
    }
}
