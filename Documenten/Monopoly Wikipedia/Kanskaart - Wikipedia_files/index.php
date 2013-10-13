/**
 * OpenStreetMap Frame
 *
 * Implementation of OpenStreetMap (from Toolserver) inside a Wikimedia wiki page.
 * @source de.wikipedia.org/wiki/MediaWiki:Common.js
 * @source meta.wikimedia.org/wiki/User:Krinkle/OpenStreetMapFrame.js
 * @author Magnus Manske, 2008
 * @author Krinkle, 2011-2012
 * @revision 4
 * @globalusage [[File:Krinkle OpenStreetMapFrame.js]]
 * @license Released under GPL
 */

// Be sure to properly test this before changing anything:
// de.wikipedia.org/wiki/Amsterdam
// nl.wikipedia.org/wiki/Amsterdam?withJS=MediaWiki:Gadget-OpenStreetMapFrame.js
// etc.

// Wikis can define these to fit their template and language
if (!window.openStreetMapFrame_id){
  window.openStreetMapFrame_id = 'coordinates';
}
if (!window.openStreetMapFrame_label){
  window.openStreetMapFrame_label = 'Map';
}

function openStreetMapFrameInit() {
  var c = document.getElementById( openStreetMapFrame_id );
  if (!c) return;
 
  var a = c.getElementsByTagName('a');
  var geohack = false;
  for (var i = 0; i < a.length; i++) {
    var h = a[i].href;
    if (!h.match(/geohack/)) continue;
    if (h.match(/_globe:/)) continue; // no OSM for moon, mars, etc
    geohack = true;
    break;
  }
  if (!geohack) return;
 
  var na = document.createElement('a');
  na.href = '#';
  na.onclick = openStreetMapFrameToggle ;
  na.appendChild(document.createTextNode( openStreetMapFrame_label ));
  c.appendChild(document.createTextNode(' ('));
  c.appendChild(na);
  c.appendChild(document.createTextNode(')     '));
}
 
function openStreetMapFrameToggle() {
  var c = document.getElementById( openStreetMapFrame_id );
  if (!c) return; 
  var cs = document.getElementById('contentSub');
  var osm = document.getElementById('openstreetmap');
 
  if (cs && osm) {
    if (osm.style.display == 'none') {
      osm.style.display = 'block';
    } else {
      osm.style.display = 'none';
    }
    return false;
  }
 
  var found_link = false;
  var a = c.getElementsByTagName('a');
  var h;
  for (var i = 0; i < a.length; i++) {
    h = a[i].href;
    if (!h.match(/geohack/)) continue;
    found_link = true;
    break;
  }
  if (!found_link) return; // No geohack link found
 
  h = h.split('params=')[1];
 
  var i = document.createElement('iframe');
  var url = '//toolserver.org/~kolossos/openlayers/kml-on-ol.php?lang=' + mw.config.get( 'wgUserLanguage' ) + '&uselang=' + mw.config.get( 'wgUserLanguage' ) + '&params=' + h;
 
  i.id = 'openstreetmap';
  i.style.width = '100%';
  i.style.height = '350px';
  i.style.clear = 'both';
  i.src = url;
  cs.appendChild(i);
  return false;
}

jQuery(document).ready(openStreetMapFrameInit);