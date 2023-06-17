using imaginnovatetest.Models;
using imaginnovatetest.Models.DTO;
using imaginnovatetest.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using AutoMapper;
using System.Xml.Linq;

namespace imaginnovatetest.Repository
{
    public class emprepository: Iemployeedetails
    {
        private readonly DataBaseContext _dbcontext;
        private readonly ILogger<emprepository> _logger;
        private readonly IMapper _mapper;

        public emprepository(DataBaseContext dbcontext, ILogger<emprepository> logger,IMapper mapper)
        {
            _dbcontext = dbcontext;            
            _logger = logger;
            _mapper = mapper;
        }


        /// <summary>
        /// Save employee details
        /// </summary>
        /// <param name="objemployeeDto"></param>
        /// <returns></returns>
        public async Task<string> Saveemployee(employeeDto objemployeeDto)
        {
            try
            {
                TblEmployee objemp = _mapper.Map<TblEmployee>(objemployeeDto);
                _dbcontext.TblEmployees.Add(objemp);
                await _dbcontext.SaveChangesAsync();
                return "Date Saved Successfully";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Get employee yearly tax details based on financial year range
        /// </summary>
        /// <param name="financialyearDto"></param>
        /// <returns></returns>
        public async Task<emptaxdetailsDto> GetEmptaxdetails(financialyearDto financialyearDto)
        {
            try
            {
                //TblEmployee objemp = _mapper.Map<TblEmployee>(objemployeeDto);
                //_dbcontext.TblEmployees.Add(objemp);
                //await _dbcontext.SaveChangesAsync();
                emptaxdetailsDto emptaxdetailsDto=new emptaxdetailsDto();

                return emptaxdetailsDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }


    }

}
