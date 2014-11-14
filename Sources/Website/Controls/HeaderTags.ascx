<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderTags.ascx.cs" Inherits="MyDay.Web.Controls.HeaderTags" %>

<link rel="stylesheet" href="/include/c/style.default.css" type="text/css" />
<link rel="stylesheet" href="/include/c/isotope.css" type="text/css" />
<link rel="stylesheet" href="/include/c/responsive-tables.css" type="text/css">
<link rel="stylesheet" href="/include/c/bootstrap-fileupload.min.css" type="text/css" />
<link rel="stylesheet" href="/include/c/bootstrap-timepicker.min.css" type="text/css" />
<link rel="stylesheet" href="/include/p/prettify.css" type="text/css" />
<link rel="stylesheet" href="/include/l/timeglider_version_1.0.3/timeglider/Timeglider.css" type="text/css">
<link rel="stylesheet" href="/include/l/timeglider_version_1.0.3/timeglider/timeglider.datepicker.css" type="text/css">

<script type="text/javascript" src="/include/j/jquery-1.9.1.min.js"></script>
<script type="text/javascript" src="/include/j/jquery-migrate-1.1.1.min.js"></script>
<script type="text/javascript" src="/include/j/jquery-ui-1.9.2.min.js"></script>
<script type="text/javascript" src="/include/p/prettify.js"></script>
<script type="text/javascript" src="/include/j/modernizr.min.js"></script>
<script type="text/javascript" src="/include/j/bootstrap.min.js"></script>
<script type="text/javascript" src="/include/j/tinymce/jquery.tinymce.js"></script>
<script type="text/javascript" src="/include/j/jquery.isotope.min.js"></script>
<script type="text/javascript" src="/include/j/jquery.colorbox-min.js"></script>
<script type="text/javascript" src="/include/j/jquery.jgrowl.js"></script>
<script type="text/javascript" src="/include/j/jquery.alerts.js"></script>
<script type="text/javascript" src="/include/j/jquery.cookie.js"></script>
<script type="text/javascript" src="/include/j/jquery.bxSlider.min.js"></script>
<script type="text/javascript" src="/include/j/bootstrap-fileupload.min.js"></script>
<script type="text/javascript" src="/include/j/bootstrap-timepicker.min.js"></script>
<script type="text/javascript" src="/include/j/jquery.smartWizard.min.js"></script>
<script type="text/javascript" src="/include/j/jquery.uniform.min.js"></script>
<script type="text/javascript" src="/include/j/jquery.validate.min.js"></script>
<script type="text/javascript" src="/include/j/jquery.tagsinput.min.js"></script>
<script type="text/javascript" src="/include/j/jquery.autogrow-textarea.js"></script>
<script type="text/javascript" src="/include/j/charCount.js"></script>
<script type="text/javascript" src="/include/j/colorpicker.js"></script>
<script type="text/javascript" src="/include/j/ui.spinner.min.js"></script>
<script type="text/javascript" src="/include/j/chosen.jquery.min.js"></script>
<script type="text/javascript" src="/include/j/flot/jquery.flot.min.js"></script>
<script type="text/javascript" src="/include/j/flot/jquery.flot.pie.min.js"></script>
<script type="text/javascript" src="/include/j/flot/jquery.flot.symbol.min.js"></script>
<script type="text/javascript" src="/include/j/flot/jquery.flot.fillbetween.min.js"></script>
<script type="text/javascript" src="/include/j/flot/jquery.flot.crosshair.min.js"></script>
<script type="text/javascript" src="/include/j/flot/jquery.flot.stack.min.js"></script>
<script type="text/javascript" src="/include/j/flot/jquery.flot.resize.min.js"></script>
<script type="text/javascript" src="/include/j/jquery.slimscroll.js"></script>
<script type="text/javascript" src="/include/j/fullcalendar.min.js"></script>
<script type="text/javascript" src="/include/j/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="/include/j/responsive-tables.js"></script>
<script type="text/javascript" src="/include/j/custom.js"></script>
<script type="text/javascript" src="/include/j/charts.js"></script>
<script type="text/javascript" src="/include/j/elements.js"></script>
<script type="text/javascript" src="/include/j/forms.js"></script>
<script type="text/javascript" src="/include/j/wysiwyg.js"></script>

<script src="/include/l/timeglider_version_1.0.3/js/underscore-min.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/js/backbone-min.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/js/json2.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/js/jquery.tmpl.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/js/ba-tinyPubSub.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/js/jquery.mousewheel.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/js/jquery.ui.ipad.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/js/globalize.js" type="text/javascript" charset="utf-8"></script>	
<script src="/include/l/timeglider_version_1.0.3/js/ba-debug.min.js" type="text/javascript" charset="utf-8"></script>

<script src="/include/l/timeglider_version_1.0.3/timeglider/TG_Date.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/timeglider/TG_Org.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/timeglider/TG_Timeline.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/timeglider/TG_TimelineView.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/timeglider/TG_Mediator.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/timeglider/timeglider.timeline.widget.js" type="text/javascript" charset="utf-8"></script>
<script src="/include/l/timeglider_version_1.0.3/timeglider/timeglider.datepicker.js" type="text/javascript" charset="utf-8"></script>