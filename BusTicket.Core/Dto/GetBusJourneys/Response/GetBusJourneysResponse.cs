﻿using Newtonsoft.Json;

namespace BusTicket.Core.Dto.GetBusJourneys.Response
{
    public class GetBusJourneysResponse
    { 
        public int id { get; set; }

        [JsonProperty("partner-id")]
        public int partnerid { get; set; }

        [JsonProperty("partner-name")]
        public string partnername { get; set; }

        [JsonProperty("route-id")]
        public int routeid { get; set; }

        [JsonProperty("bus-type")]
        public string bustype { get; set; }

        [JsonProperty("bus-type-name")]
        public string bustypename { get; set; }

        [JsonProperty("total-seats")]
        public int totalseats { get; set; }

        [JsonProperty("available-seats")]
        public int availableseats { get; set; }
        public Journey journey { get; set; }
        public List<Feature> features { get; set; }

        [JsonProperty("origin-location")]
        public string originlocation { get; set; }

        [JsonProperty("destination-location")]
        public string destinationlocation { get; set; }

        [JsonProperty("is-active")]
        public bool isactive { get; set; }

        [JsonProperty("origin-location-id")]
        public int originlocationid { get; set; }

        [JsonProperty("destination-location-id")]
        public int destinationlocationid { get; set; }

        [JsonProperty("is-promoted")]
        public bool ispromoted { get; set; }

        [JsonProperty("cancellation-offset")]
        public int? cancellationoffset { get; set; }

        [JsonProperty("has-bus-shuttle")]
        public bool hasbusshuttle { get; set; }

        [JsonProperty("disable-sales-without-gov-id")]
        public bool disablesaleswithoutgovid { get; set; }

        [JsonProperty("display-offset")]
        public string displayoffset { get; set; }

        [JsonProperty("partner-rating")]
        public double? partnerrating { get; set; }

        [JsonProperty("has-dynamic-pricing")]
        public bool hasdynamicpricing { get; set; }

        [JsonProperty("disable-sales-without-hes-code")]
        public bool disablesaleswithouthescode { get; set; }

        [JsonProperty("disable-single-seat-selection")]
        public bool disablesingleseatselection { get; set; }

        [JsonProperty("change-offset")]
        public int? changeoffset { get; set; }
        public int? rank { get; set; }

        [JsonProperty("display-coupon-code-input")]
        public bool displaycouponcodeinput { get; set; }

        [JsonProperty("disable-sales-without-date-of-birth")]
        public bool disablesaleswithoutdateofbirth { get; set; }

        [JsonProperty("open-offset")]
        public int? openoffset { get; set; }

        [JsonProperty("display-buffer")]
        public object displaybuffer { get; set; }

        [JsonProperty("allow-sales-foreign-passenger")]
        public bool allowsalesforeignpassenger { get; set; }

        [JsonProperty("has-seat-selection")]
        public bool hasseatselection { get; set; }

        [JsonProperty("branded-fares")]
        public List<object> brandedfares { get; set; }

        [JsonProperty("has-gender-selection")]
        public bool hasgenderselection { get; set; }

        [JsonProperty("has-dynamic-cancellation")]
        public bool hasdynamiccancellation { get; set; }

        [JsonProperty("partner-terms-and-conditions")]
        public object partnertermsandconditions { get; set; }

        [JsonProperty("partner-available-alphabets")]
        public string partneravailablealphabets { get; set; }

        [JsonProperty("provider-name")]
        public string providername { get; set; }

        [JsonProperty("enable-full-journey-display")]
        public bool enablefulljourneydisplay { get; set; }
    }

    public class Feature
    {
        public int id { get; set; }
        public int? priority { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        [JsonProperty("is-promoted")]
        public bool ispromoted { get; set; }

        [JsonProperty("back-color")]
        public string backcolor { get; set; }

        [JsonProperty("fore-color")]
        public string forecolor { get; set; }
    }

    public class Journey
    {
        public string kind { get; set; }
        public string code { get; set; }
        public List<Stop> stops { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime departure { get; set; }
        public DateTime arrival { get; set; }
        public string currency { get; set; }
        public string duration { get; set; }

        [JsonProperty("original-price")]
        public double originalprice { get; set; }

        [JsonProperty("internet-price")]
        public double internetprice { get; set; }

        [JsonProperty("provider-internet-price")]
        public double? providerinternetprice { get; set; }
        public object booking { get; set; }

        [JsonProperty("bus-name")]
        public string busname { get; set; }
        public Policy policy { get; set; }
        public List<string> features { get; set; }
        public string description { get; set; }
        public object available { get; set; }
    }

    public class Policy
    {
        [JsonProperty("max-seats")]
        public object maxseats { get; set; }

        [JsonProperty("max-single")]
        public int? maxsingle { get; set; }

        [JsonProperty("max-single-males")]
        public int? maxsinglemales { get; set; }

        [JsonProperty("max-single-females")]
        public int? maxsinglefemales { get; set; }

        [JsonProperty("mixed-genders")]
        public bool mixedgenders { get; set; }

        [JsonProperty("gov-id")]
        public bool govid { get; set; }
        public bool lht { get; set; }
    }

    public class Root
    {
        public List<GetBusJourneysResponse> data { get; set; }
    }

    public class Stop
    {
        public int id { get; set; }
        public int? kolayCarLocationId { get; set; }
        public string name { get; set; }
        public string station { get; set; }
        public DateTime? time { get; set; }

        [JsonProperty("is-origin")]
        public bool isorigin { get; set; }

        [JsonProperty("is-destination")]
        public bool isdestination { get; set; }
    }


}
