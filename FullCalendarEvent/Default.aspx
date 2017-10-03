<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Calendar" %>

<!DOCTYPE html>
<html>
<head>
<meta charset='utf-8' />
<link href='Content/bootstrap.min.css' rel='stylesheet' />
<link href='Content/fullcalendar.min.css' rel='stylesheet' />
<link href='Content/fullcalendar.print.min.css' rel='stylesheet' media='print' />
<link href='Content/custom.css' rel='stylesheet'/>
<script src='scripts/moment.min.js'></script>
<script src='scripts/jquery.min.js'></script>
<script src='scripts/bootstrap.min.js'></script>
<script src='scripts/fullcalendar.min.js'></script>
<script>

    $(document).ready(function () {
        var jsonStr = <%= @_json_vals %>; 

        $('#calendar').fullCalendar({
            defaultDate: $.now(),
            header: {
                left: 'prev,next today',
                center: 'title',
                right: 'month,agendaWeek,agendaDay,listWeek'
            },
            navLinks: true, // can click day/week names to navigate views
            editable: false,
            eventLimit: true, // allow "more" link when too many events
            events: jsonStr
        });

    });

</script>
<style>

	body {
		margin: 40px 10px;
		padding: 0;
		font-family: "Lucida Grande",Helvetica,Arial,Verdana,sans-serif;
		font-size: 14px;
	}

	#calendar {
		max-width: 900px;
		margin: 0 auto;
	}

</style>
</head>
<body>

	<div id='calendar'></div>

</body>
</html>
