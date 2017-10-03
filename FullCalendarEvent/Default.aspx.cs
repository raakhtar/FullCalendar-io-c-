using System;
using Newtonsoft.Json;
using System.Collections.Generic;

public partial class _Calendar : System.Web.UI.Page 
{
    public string _json_vals;

    public class Event
    {
        public int id;
        public string title;
        public string start;
        public string end;
        public string url;
    }
    private void GetEvents()
    {
        List<Event> eList = new List<Event>();
        Event e = new Event();
        e.title = "Google Conference";
        e.start= "2017-10-03";
        e.end = "2017-10-04";
        e.url = "http://google.com";
        eList.Add(e);

        e = new Event();
        e.id = 9;
        e.title = "Microsoft Conference";
        e.start = "2017-10-05";
        e.end = "2017-10-06";
        eList.Add(e);

        e = new Event();
        e.id = 10;
        e.title = "Telegraph Event";
        e.start = "2017-10-05";
        e.end = "2017-10-06";
        eList.Add(e);

        e = new Event();
        e.id = 11;
        e.title = "Crypto Event";
        e.start = "2017-10-05T12:00:00";
        e.end = "2017-10-06";
        eList.Add(e);

        e = new Event();
        e.id = 12;
        e.title = "UAE Event";
        e.start = "2017-10-05T10:30:00";
        e.end = "2017-10-06";
        eList.Add(e);

        e = new Event();
        e.id = 13;
        e.title = "KSA Event";
        e.start = "2017-10-05T15:00:00";
        e.end = "2017-10-06";
        eList.Add(e);

        e = new Event();
        e.id = 14;
        e.title = "Pak Event";
        e.start = "2017-10-05";
        e.end = "2017-10-06";
        eList.Add(e);

        e = new Event();
        e.id = 999;
        e.title = "Off the record Event";
        e.start = "2017-10-07";
        e.end = "2017-10-07";
        eList.Add(e);

        _json_vals = JsonConvert.SerializeObject(eList, Formatting.Indented);             
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        GetEvents();               
    }
}
