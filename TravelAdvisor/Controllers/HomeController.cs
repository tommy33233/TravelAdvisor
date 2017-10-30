using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using BLL.DTO;
using BLL.Interfaces;
using TravelAdvisor.Models;
using BLL.Infrastructure;

namespace TravelAdvisor.Controllers
{
    public class HomeController : Controller
    {
        private IService service;

        public HomeController(IService serv)
        {
            service = serv;
        }

        //public HomeController()
        //{
        //}

        public ActionResult Index()
        {
            IEnumerable<CountryDTO> countryDtos = service.GetCountries();
            //Mapper.Initialize(cfg => cfg.CreateMap<CountryDTO, CountryViewModel>());
            //var countries = Mapper.Map<IEnumerable<CountryDTO>, List<CountryViewModel>>(countryDtos);
            var countries = countryDtos.Select(x => CountryViewModel.CountryDTOToView(x));
            //Mapper.Initialize(cfg => cfg.CreateMap<CountryDTO, CountryViewModel>()
            //        .ForMember("PhoneId", opt => opt.MapFrom(src => src.Id)));


            //IEnumerable<CityDTO> cityDtos = service.GetCities();
            //Mapper.Initialize(cfg => cfg.CreateMap<CityDTO, CityViewModel>());
            //var cities = Mapper.Map<IEnumerable<CityDTO>, List<CityViewModel>>(cityDtos);

            //IEnumerable<RegionDTO> regionDtos = service.GetRegions();
            //Mapper.Initialize(cfg => cfg.CreateMap<RegionDTO, RegionViewModel>());
            //var regions = Mapper.Map<IEnumerable<RegionDTO>, List<RegionViewModel>>(regionDtos);

            //var geolocation = new {countries, cities, regions};
          //  return View(geolocation);
            return View(countries);
        }

        public ActionResult Attractions()
        {
            var attractions = service.GetAttractions();
            var att = attractions.Select(x => AttractionsViewModel.AttractionsFromDTOToViewModel(x));
            return View(att);
        }

        [HttpPost]
        public ActionResult AddCity(CityViewModel city)
        {
            try
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<CityViewModel, CityDTO>());
                //var cityDto = Mapper.Map<CityViewModel, CityDTO>(city);
                //service.AddCity(cityDto);

                service.AddCity(CityViewModel.CityFromViewToDto(city));
            }
            catch (ValidationException ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
            }
            return View(city);
        }



    }
}