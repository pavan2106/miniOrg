!function(){"use strict";function t(t){return{restrict:"CA",scope:{data:"=",labels:"=",options:"=",series:"=",colours:"=?",getColour:"=?",chartType:"=",legend:"@",click:"=",hover:"="},link:function(n,a){function o(e,o){if(!v(e)&&!angular.equals(e,o)){var l=t||n.chartType;l&&(i&&i.destroy(),i=r(l,n,a))}}var i,l=document.createElement("div");l.className="chart-container",a.replaceWith(l),l.appendChild(a[0]),"object"==typeof window.G_vmlCanvasManager&&null!==window.G_vmlCanvasManager&&"function"==typeof window.G_vmlCanvasManager.initElement&&window.G_vmlCanvasManager.initElement(a[0]),n.$watch("data",function(o,l){if(o&&o.length&&(!Array.isArray(o[0])||o[0].length)){var c=t||n.chartType;if(c){if(i){if(e(o,l))return p(i,o,n);i.destroy()}i=r(c,n,a)}}},!0),n.$watch("series",o,!0),n.$watch("labels",o,!0),n.$watch("options",o,!0),n.$watch("colours",o,!0),n.$watch("chartType",function(t,e){v(t)||angular.equals(t,e)||(i&&i.destroy(),i=r(t,n,a))}),n.$on("$destroy",function(){i&&i.destroy()})}}}function e(t,e){return t&&e&&t.length&&e.length?Array.isArray(t[0])?t.length===e.length&&t[0].length===e[0].length:e.reduce(n,0)>0?t.length===e.length:!1:!1}function n(t,e){return t+e}function r(t,e,n){if(e.data&&e.data.length){e.getColour="function"==typeof e.getColour?e.getColour:l,e.colours=o(e);var r=n[0],i=r.getContext("2d"),c=Array.isArray(e.data[0])?h(e.labels,e.data,e.series||[],e.colours):g(e.labels,e.data,e.colours),u=new Chart(i)[t](c,e.options||{});return e.$emit("create",u),["hover","click"].forEach(function(t){e[t]&&(r["click"===t?"onclick":"onmousemove"]=a(e,u,t))}),e.legend&&"false"!==e.legend&&d(n,u),u}}function a(t,e,n){return function(r){var a=e.getPointsAtEvent||e.getBarsAtEvent||e.getSegmentsAtEvent;if(a){var o=a.call(e,r);t[n](o,r),t.$apply()}}}function o(t){for(var e=angular.copy(t.colours)||angular.copy(Chart.defaults.global.colours);e.length<t.data.length;)e.push(t.getColour());return e.map(i)}function i(t){return"object"==typeof t&&null!==t?t:"string"==typeof t&&"#"===t[0]?c(f(t.substr(1))):l()}function l(){var t=[u(0,255),u(0,255),u(0,255)];return c(t)}function c(t){return{fillColor:s(t,.2),strokeColor:s(t,1),pointColor:s(t,1),pointStrokeColor:"#fff",pointHighlightFill:"#fff",pointHighlightStroke:s(t,.8)}}function u(t,e){return Math.floor(Math.random()*(e-t+1))+t}function s(t,e){return"rgba("+t.concat(e).join(",")+")"}function f(t){var e=parseInt(t,16),n=e>>16&255,r=e>>8&255,a=255&e;return[n,r,a]}function h(t,e,n,r){return{labels:t,datasets:e.map(function(t,e){var a=angular.copy(r[e]);return a.label=n[e],a.data=t,a})}}function g(t,e,n){return t.map(function(t,r){return{label:t,value:e[r],color:n[r].strokeColor,highlight:n[r].pointHighlightStroke}})}function d(t,e){var n=t.parent(),r=n.find("chart-legend"),a="<chart-legend>"+e.generateLegend()+"</chart-legend>";r.length?r.replaceWith(a):n.append(a)}function p(t,e,n){Array.isArray(n.data[0])?t.datasets.forEach(function(t,n){(t.points||t.bars).forEach(function(t,r){t.value=e[n][r]})}):t.segments.forEach(function(t,n){t.value=e[n]}),t.update(),n.$emit("update",t)}function v(t){return!t||Array.isArray(t)&&!t.length||"object"==typeof t&&!Object.keys(t).length}Chart.defaults.global.responsive=!0,Chart.defaults.global.multiTooltipTemplate="<%if (datasetLabel){%><%=datasetLabel%>: <%}%><%= value %>",Chart.defaults.global.colours=["#97BBCD","#DCDCDC","#F7464A","#46BFBD","#FDB45C","#949FB1","#4D5360"],angular.module("chart.js",[]).directive("chartBase",function(){return t()}).directive("chartLine",function(){return t("Line")}).directive("chartBar",function(){return t("Bar")}).directive("chartRadar",function(){return t("Radar")}).directive("chartDoughnut",function(){return t("Doughnut")}).directive("chartPie",function(){return t("Pie")}).directive("chartPolarArea",function(){return t("PolarArea")})}();
//# sourceMappingURL=angular-chart.min.js.map