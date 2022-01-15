namespace DpsCalculator.Tests.TestFiles;

public class CannonBase : ITestHtml
{
	public CannonBase()
    {
        Html = @"
		<!DOCTYPE html>
		<html class=""client-nojs"" lang=""en-GB"" dir=""ltr"">
		<head>
		<meta charset=""UTF-8""/>
		<title>Cannon base - OSRS Wiki</title>
		<script>document.documentElement.className=""client-js"";RLCONF={""wgBreakFrames"":false,""wgSeparatorTransformTable"":["""",""""],""wgDigitTransformTable"":["""",""""],""wgDefaultDateFormat"":""dmy"",""wgMonthNames"":["""",""January"",""February"",""March"",""April"",""May"",""June"",""July"",""August"",""September"",""October"",""November"",""December""],""wgRequestId"":""7568fed8f5ddf35ee8f6ae1c2f91e16c"",""wgCSPNonce"":false,""wgCanonicalNamespace"":"""",""wgCanonicalSpecialPageName"":false,""wgNamespaceNumber"":0,""wgPageName"":""Cannon_base"",""wgTitle"":""Cannon base"",""wgCurRevisionId"":14068091,""wgRevisionId"":14068091,""wgArticleId"":19175,""wgIsArticle"":true,""wgIsRedirect"":false,""wgAction"":""view"",""wgUserName"":""Welfare PvM"",""wgUserGroups"":[""*"",""user"",""autoconfirmed""],""wgCategories"":[""Items"",""Tradeable items"",""Grand Exchange items"",""Members' items"",""Quest items"",""Dwarf Cannon""],""wgPageContentLanguage"":""en-gb"",""wgPageContentModel"":""wikitext"",""wgRelevantPageName"":""Cannon_base"",""wgRelevantArticleId"":19175,""wgUserId"":36843170,""wgUserEditCount"":83,
		""wgUserRegistration"":null,""wgIsProbablyEditable"":true,""wgRelevantPageIsProbablyEditable"":true,""wgRestrictionEdit"":[],""wgRestrictionMove"":[],""wgVectorDisableSidebarPersistence"":false,""wgMediaViewerOnClick"":true,""wgMediaViewerEnabledByDefault"":true,""wgVisualEditor"":{""pageLanguageCode"":""en-GB"",""pageLanguageDir"":""ltr"",""pageVariantFallbacks"":""en-gb""},""wgMFDisplayWikibaseDescriptions"":{""search"":false,""nearby"":false,""watchlist"":false,""tagline"":false},""wgPopupsFlags"":2,""simpleBatchUploadMaxFilesPerBatch"":{""*"":1000},""wgEditSubmitButtonLabelPublish"":false,""wgEchoSeenTime"":{""alert"":""1970-01-01T00:00:01Z"",""notice"":""1970-01-01T00:00:01Z""}};RLSTATE={""ext.gadget.switch-infobox-styles"":""ready"",""ext.gadget.stickyTableHeaders"":""ready"",""ext.gadget.showAdvancedData"":""ready"",""site.styles"":""ready"",""user.styles"":""ready"",""user"":""ready"",""user.options"":""loading"",""skins.vector.styles.legacy"":""ready"",""jquery.tablesorter.styles"":""ready"",""jquery.makeCollapsible.styles"":""ready"",
		""ext.visualEditor.desktopArticleTarget.noscript"":""ready"",""ext.echo.styles.badge"":""ready"",""oojs-ui.styles.icons-alerts"":""ready"",""ext.smw.style"":""ready"",""ext.smw.tooltip.styles"":""ready""};RLPAGEMODULES=[""ext.smw.style"",""ext.smw.tooltips"",""ext.scribunto.logs"",""site"",""mediawiki.page.ready"",""jquery.tablesorter"",""jquery.makeCollapsible"",""skins.vector.legacy.js"",""mediawiki.page.watch.ajax"",""mmv.head"",""mmv.bootstrap.autostart"",""ext.gadget.rsw-util"",""ext.gadget.switch-infobox"",""ext.gadget.exchangePages"",""ext.gadget.GECharts"",""ext.gadget.compare"",""ext.gadget.autosort"",""ext.gadget.highlightTable"",""ext.gadget.titleparenthesis"",""ext.gadget.tooltips"",""ext.gadget.topIcons"",""ext.gadget.Username"",""ext.gadget.countdown"",""ext.gadget.autocollapse"",""ext.gadget.checkboxList"",""ext.gadget.Charts"",""ext.gadget.realtimeExchange"",""ext.gadget.navbox-tracking"",""ext.gadget.sidebar-tracking"",""ext.gadget.calc"",""ext.gadget.infoboxQty"",""ext.gadget.calculatorNS"",""ext.gadget.dropDisplay"",""ext.gadget.mmgkc"",""ext.gadget.dps""
		,""ext.gadget.contributions"",""ext.gadget.code-snippets"",""ext.gadget.skinTogglesNew"",""ext.gadget.utcclock"",""ext.gadget.relativetime"",""ext.gadget.sectionAnchors"",""ext.gadget.audioplayer"",""ext.gadget.musicmap"",""ext.gadget.equipment"",""ext.gadget.falseSubpage"",""ext.gadget.dropdown"",""ext.gadget.newPage"",""ext.gadget.purge"",""ext.gadget.ReferenceTooltips"",""ext.gadget.fileDownload"",""ext.gadget.batchupload"",""ext.gadget.oswf"",""ext.gadget.sigreminder"",""ext.visualEditor.desktopArticleTarget.init"",""ext.visualEditor.targetLoader"",""ext.echo.init"",""ext.popups"",""ext.smw.purge""];</script>
		<script>(RLQ=window.RLQ||[]).push(function(){mw.loader.implement(""user.options@1hzgi"",function($,jQuery,require,module){/*@nomin*/mw.user.tokens.set({""patrolToken"":""2b381babe3a5e5f01d94580ff9142d4361e20c7a+\\"",""watchToken"":""881a6eeb864bc129578fab35ad0678b361e20c7a+\\"",""csrfToken"":""2ba4507b0a31bd881a4b17dfbeb4430d61e20c7a+\\""});mw.user.options.set({""visualeditor-editor"":""wikitext"",""visualeditor-hidebetawelcome"":""1"",""echo-subscriptions-email-edit-user-talk"":1,""gadget-showAdvancedData"":""1"",""rcfilters-limit"":""500"",""rcfilters-saved-queries"":""{\""queries\"":{},\""version\"":\""2\""}"",""visualeditor-diffmode-visual"":""\""visual\"""",""visualeditor-hideusered"":""1""});
		});});</script>
		<link rel=""stylesheet"" href=""/load.php?lang=en-gb&amp;modules=ext.echo.styles.badge%7Cext.visualEditor.desktopArticleTarget.noscript%7Cjquery.makeCollapsible.styles%7Cjquery.tablesorter.styles%7Coojs-ui.styles.icons-alerts%7Cskins.vector.styles.legacy&amp;only=styles&amp;skin=vector&amp;wgl=2""/>
		<link rel=""stylesheet"" href=""/load.php?lang=en-gb&amp;modules=ext.smw.style%7Cext.smw.tooltip.styles&amp;only=styles&amp;skin=vector&amp;wgl=2""/>
		<script async="""" src=""/load.php?lang=en-gb&amp;modules=startup&amp;only=scripts&amp;raw=1&amp;skin=vector&amp;wgl=2""></script>
		<meta name=""ResourceLoaderDynamicStyles"" content=""""/>
		<link rel=""stylesheet"" href=""/load.php?lang=en-gb&amp;modules=ext.gadget.showAdvancedData%2CstickyTableHeaders%2Cswitch-infobox-styles&amp;only=styles&amp;skin=vector&amp;wgl=2""/>
		<link rel=""stylesheet"" href=""/load.php?lang=en-gb&amp;modules=site.styles&amp;only=styles&amp;skin=vector&amp;wgl=2""/>
		<meta name=""generator"" content=""MediaWiki 1.36.3""/>
		<meta name=""format-detection"" content=""telephone=no""/>
		<meta name=""description"" content=""The cannon base is the first part of the dwarf multicannon to be set up, followed by the stand. The Dwarf cannon quest must be completed to use it. It is purchased from Multicannon parts for sale for 200,625 coins.""/>
		<meta property=""og:image"" content=""https://oldschool.runescape.wiki/images/Cannon_base_detail.png?8e7b2""/>
		<link rel=""alternate"" type=""application/rdf+xml"" title=""Cannon base"" href=""/w/Special:ExportRDF/Cannon_base?xmlmime=rdf""/>
		<link rel=""alternate"" type=""application/x-wiki"" title=""Edit"" href=""/w/Cannon_base?action=edit""/>
		<link rel=""shortcut icon"" href=""/favicon.ico""/>
		<link rel=""search"" type=""application/opensearchdescription+xml"" href=""/opensearch_desc.php"" title=""Old School RuneScape Wiki (en-gb)""/>
		<link rel=""EditURI"" type=""application/rsd+xml"" href=""https://oldschool.runescape.wiki/api.php?action=rsd""/>
		<link rel=""license"" href=""https://creativecommons.org/licenses/by-nc-sa/3.0/""/>
		<link rel=""canonical"" href=""https://oldschool.runescape.wiki/w/Cannon_base""/>
			<meta property=""og:type"" content=""article""/>

			<meta property=""og:site_name"" content=""Old School RuneScape Wiki""/>

			<meta property=""og:title"" content=""Cannon base""/>

			<meta property=""og:description"" content=""The cannon base is the first part of the dwarf multicannon to be set up, followed by the stand. The Dwarf cannon quest must be completed to use it. It is purchased from Multicannon parts for sale for 200,625 coins.""/>

			<meta property=""og:url"" content=""https://oldschool.runescape.wiki/w/Cannon_base""/>

		<script>(function(w,d){!function(e,t,r,a,s){e[r]=e[r]||{},e[r].executed=[],e.zaraz={deferred:[]};var n=t.getElementsByTagName(""title"")[0];e[r].c=t.cookie,n&&(e[r].t=t.getElementsByTagName(""title"")[0].text),e[r].w=e.screen.width,e[r].h=e.screen.height,e[r].j=e.innerHeight,e[r].e=e.innerWidth,e[r].l=e.location.href,e[r].r=t.referrer,e[r].k=e.screen.colorDepth,e[r].n=t.characterSet,e[r].o=(new Date).getTimezoneOffset(),//
		e[s]=e[s]||[],e.zaraz._preTrack=[],e.zaraz.track=(t,r)=>e.zaraz._preTrack.push([t,r]),e[s].push({""zaraz.start"":(new Date).getTime()});var i=t.getElementsByTagName(a)[0],o=t.createElement(a);o.defer=!0,o.src=""/cdn-cgi/zaraz/s.js?""+new URLSearchParams(e[r]).toString(),i.parentNode.insertBefore(o,i)}(w,d,""zarazData"",""script"",""dataLayer"");})(window,document);</script></head>
		<body class=""mediawiki ltr sitedir-ltr mw-hide-empty-elt ns-0 ns-subject mw-editable page-Cannon_base rootpage-Cannon_base skin-vector action-view skin-vector-legacy wgl-lightmode""><div id=""mw-page-base"" class=""noprint""></div>
		<div id=""mw-head-base"" class=""noprint""></div>
		<div id=""content"" class=""mw-body"" role=""main"">
			<a id=""top""></a>
			<div id=""siteNotice"" class=""mw-body-content""></div>
			<div class=""mw-indicators mw-body-content"">
			</div>
			<h1 id=""firstHeading"" class=""firstHeading"" >Cannon base</h1>
			<div id=""bodyContent"" class=""mw-body-content"">
				<div id=""siteSub"" class=""noprint"">From Old School RuneScape Wiki</div>
				<div id=""contentSub""></div>
				<div id=""contentSub2""></div>
				
				<div id=""jump-to-nav""></div>
				<a class=""mw-jump-link"" href=""#mw-head"">Jump to navigation</a>
				<a class=""mw-jump-link"" href=""#searchInput"">Jump to search</a>
				<div id=""mw-content-text"" lang=""en-GB"" dir=""ltr"" class=""mw-content-ltr""><div class=""mw-parser-output""><div class=""rs-external-header-links"" style=""display:none""><span class=""rs-header-icon rs-header-icon-rs"" data-text=""RuneScape"" data-title=""The RuneScape Wiki also has an article on Cannon base."" data-site=""rs"">The RuneScape Wiki also has an article on: <a href=""https://runescape.wiki/w/Cannon_base"" class=""extiw"" title=""rsw:Cannon base"">rsw:Cannon base</a></span><span class=""rs-header-icon rs-header-icon-rsc"" data-text=""CS"" data-title=""The RuneScape Classic Wiki also has an article on Dwarf cannon base."" data-site=""rsc"">The RuneScape Classic Wiki also has an article on: <a href=""https://classic.runescape.wiki/w/Dwarf_cannon_base"" class=""extiw"" title=""classicrsw:Dwarf cannon base"">classicrsw:Dwarf cannon base</a></span></div>
		<table class=""rsw-infobox infobox no-parenthesis-style infobox-item""><tbody><tr><th colspan=""20"" class=""infobox-header"">Cannon base</th></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr><td colspan=""20"" class=""infobox-image inventory-image infobox-full-width-content""><a href=""/w/File:Cannon_base.png"" class=""image""><img alt=""Cannon base.png"" src=""/images/Cannon_base.png?3c432"" decoding=""async"" width=""22"" height=""29"" data-file-width=""22"" data-file-height=""29"" /></a></td></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr><th colspan=""7"">Released</th><td colspan=""13""><a href=""/w/27_May"" title=""27 May"">27 May</a> <a href=""/w/2003"" title=""2003"">2003</a> (<a href=""/w/Update:New_Dwarf_Cannon_Quest"" title=""Update:New Dwarf Cannon Quest"">Update</a>)</td></tr><tr><th colspan=""7""><a href=""/w/Members"" title=""Members"">Members</a></th><td colspan=""13"">Yes</td></tr><tr><th colspan=""7""><a href=""/w/Quest_items"" title=""Quest items"">Quest item</a></th><td colspan=""13""><a href=""/w/Dwarf_Cannon"" title=""Dwarf Cannon"">Dwarf Cannon</a></td></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr><th colspan=""20"" class=""infobox-subheader"">Properties</th></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr><th colspan=""7""><a href=""/w/Items#Tradeability"" title=""Items"">Tradeable</a></th><td colspan=""13"">Yes</td></tr><tr><th colspan=""7""><a href=""/w/Worn_Equipment"" title=""Worn Equipment"">Equipable</a></th><td colspan=""13"">No</td></tr><tr><th colspan=""7""><a href=""/w/Stackable_items"" title=""Stackable items"">Stackable</a></th><td colspan=""13"">No</td></tr><tr><th colspan=""7""><a href=""/w/Note"" class=""mw-redirect"" title=""Note"">Noteable</a></th><td colspan=""13"">Yes</td></tr><tr><th colspan=""7""><a href=""/w/Choose_Option"" title=""Choose Option"">Options</a></th><td colspan=""13"">Set-up</td></tr><tr><th colspan=""7""><a href=""/w/Destroy"" title=""Destroy"">Destroy</a></th><td colspan=""13"">Drop</td></tr><tr><th colspan=""7""><a href=""/w/Examine"" title=""Examine"">Examine</a></th><td colspan=""13"">The cannon is built on this.</td></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr><th colspan=""20"" class=""infobox-subheader"">Values</th></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr><th colspan=""7""><a href=""/w/Value"" title=""Value"">Value</a></th><td colspan=""13"">187,500 coins</td></tr><tr><th colspan=""7""><a href=""/w/High_Level_Alchemy"" title=""High Level Alchemy"">High alch</a></th><td colspan=""13"">112,500 coins</td></tr><tr><th colspan=""7""><a href=""/w/Low_Level_Alchemy"" title=""Low Level Alchemy"">Low alch</a></th><td colspan=""13"">75,000 coins</td></tr><tr><th colspan=""7""><a href=""/w/Weight"" title=""Weight"">Weight</a></th><td colspan=""13"">10 kg</td></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr><th colspan=""20"" class=""infobox-subheader"">Grand Exchange</th></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr><th colspan=""7""><a href=""/w/RuneScape:Grand_Exchange_Market_Watch"" title=""RuneScape:Grand Exchange Market Watch"">Exchange</a></th><td colspan=""13""><span class=""infobox-quantity"" data-val-each=""185984""><span class=""infobox-quantity-replace"">185,984</span> coins (<a href=""/w/Exchange:Cannon_base"" title=""Exchange:Cannon base"">info</a>)</span></td></tr><tr><th colspan=""7""><a href=""/w/Grand_Exchange#Buy_limits"" title=""Grand Exchange"">Buy limit</a></th><td colspan=""13"">70</td></tr><tr><th colspan=""7""><a href=""/w/Grand_Exchange#Volume"" title=""Grand Exchange"">Daily volume</a></th><td colspan=""13"">363</td></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr><td colspan=""20"" class=""infobox-full-width-content""><div class=""realtimePrices"" style=""display: none;"" data-itemid=""6""></div></td></tr><tr><td colspan=""20"" class=""infobox-full-width-content""><div class=""GEChartBox""><div class=""GEChartItems"" style=""display:none""></div><div class=""GEdatachart smallChart"" style=""height:160px;margin:0 auto;width:258px""><div style=""color:#666;text-align:center;font-size:11px"">Loading...</div></div><div class=""GEdataprices"" data-item=""Cannon base"" data-itemid=""6"" data-limit=""70"" data-value=""187500"" style=""display:none""></div></div></td></tr><tr><td colspan=""20"" class=""infobox-padding""></td></tr><tr class=""advanced-data""><th colspan=""20"" class=""infobox-subheader"">Advanced data</th></tr><tr class=""advanced-data""><td colspan=""20"" class=""infobox-padding""></td></tr><tr class=""advanced-data""><th colspan=""7"">Item ID</th><td colspan=""13"">6</td></tr><tr class=""advanced-data""><td colspan=""20"" class=""infobox-padding""></td></tr></tbody></table><div class=""infobox-smw-data"" style=""display:none""></div>
		<div class=""floatleft""><a href=""/w/File:Cannon_base_detail.png"" class=""image""><img alt=""Cannon base detail.png"" src=""/images/thumb/Cannon_base_detail.png/130px-Cannon_base_detail.png?8e7b2"" decoding=""async"" width=""130"" height=""180"" srcset=""/images/thumb/Cannon_base_detail.png/195px-Cannon_base_detail.png?8e7b2 1.5x, /images/thumb/Cannon_base_detail.png/260px-Cannon_base_detail.png?8e7b2 2x"" data-file-width=""1056"" data-file-height=""1461"" /></a></div>
		<p>The <b>cannon base</b> is the first part of the <a href=""/w/Dwarf_multicannon"" title=""Dwarf multicannon"">dwarf multicannon</a> to be set up, followed by the stand. The <a href=""/w/Dwarf_cannon"" class=""mw-redirect"" title=""Dwarf cannon"">Dwarf cannon</a> <a href=""/w/Quest"" class=""mw-redirect"" title=""Quest"">quest</a> must be completed to use it. It is purchased from <a href=""/w/Multicannon_parts_for_sale"" title=""Multicannon parts for sale"">Multicannon parts for sale</a> for <span class=""coins coins-pos"">200,625</span> coins.
		</p><p>The cannon base by itself can decay without having the full cannon set up. When lost, a new cannon base can be obtained from <a href=""/w/Nulodion"" title=""Nulodion"">Nulodion</a>, free of charge.
		</p>
		<h2><span class=""mw-headline"" id=""Shop_locations"">Shop locations</span><span class=""mw-editsection""><span class=""mw-editsection-bracket"">[</span><a href=""/w/Cannon_base?section=1&amp;veaction=edit"" class=""mw-editsection-visualeditor"" title=""Edit section: Shop locations"">edit</a><span class=""mw-editsection-divider""> | </span><a href=""/w/Cannon_base?action=edit&amp;section=1"" title=""Edit section: Shop locations"">edit source</a><span class=""mw-editsection-bracket"">]</span></span></h2>
		<div class=""seealso"">This list was created dynamically. For help, see <a href=""/w/Template:Store_locations_list/FAQ"" title=""Template:Store locations list/FAQ"">the FAQ</a>. To force an update of this list, click <span class=""plainlinks jsPurgeLink"" id=""res"" title=""If this information seems incorrect, click here to force an update.""><a class=""text"" href=""https://oldschool.runescape.wiki/w/Cannon_base?action=purge#res"">here</a></span>.</div>
		<table class=""wikitable sortable align-center-3 align-center-4 align-center-5 align-center-6 align-center-7""><tbody><tr><th>Seller</th><th>Location</th><th data-sort-type=""number"">Number<br />in stock</th><th data-sort-type=""number"">Restock<br />time</th><th data-sort-type=""number"">Price<br />sold at</th><th data-sort-type=""number"">Price<br />bought at</th><th>Members?</th></tr><tr><td><a href=""/w/Multicannon_parts_for_sale"" title=""Multicannon parts for sale"">Multicannon parts for sale</a></td><td><a href=""/w/Ice_Mountain"" title=""Ice Mountain"">Ice Mountain</a> workshop</td><td data-sort-value=""5"">5</td><td data-sort-value=""100"">1m </td><td data-sort-value=""200625""><a href=""/w/Coins"" title=""Coins""><img alt=""Coins 10000.png"" src=""/images/Coins_10000.png?7fa38"" decoding=""async"" width=""30"" height=""29"" data-file-width=""30"" data-file-height=""29"" /></a> 200,625</td><td data-sort-value=""75000""><a href=""/w/Coins"" title=""Coins""><img alt=""Coins 10000.png"" src=""/images/Coins_10000.png?7fa38"" decoding=""async"" width=""30"" height=""29"" data-file-width=""30"" data-file-height=""29"" /></a> 75,000</td><td><a href=""/w/Pay-to-play"" title=""Pay-to-play""><img alt=""Member icon.png"" src=""/images/Member_icon.png?1de0c"" decoding=""async"" width=""16"" height=""16"" data-file-width=""16"" data-file-height=""16"" /></a></td></tr></tbody></table>
		<table class=""navbox nowraplinks mw-collapsible"" data-expandtext=""show"" data-navbox-name=""Cannon"" data-collapsetext=""hide""><tbody><tr><th colspan=""2"" class=""navbox-title"" id=""navbox-title""><div class=""navbox-title-name-notplain""><div class=""navbar"" style=""float:left;text-align:left;width:6em""><div class=""plainlinks noprint"" style=""background-color:transparent;padding:0;font-weight:normal;font-size:xx-small;white-space:nowrap""><a href=""/w/Template:Cannon"" title=""Template:Cannon""><span title=""View this template"">v</span></a>&#160;<span style=""font-size:80%"">&#8226;</span>&#160;<a class=""text"" href=""https://oldschool.runescape.wiki/w/Template_talk:Cannon""><span title=""Discussion about this template"">d</span></a>&#160;<span style=""font-size:80%"">&#8226;</span>&#160;<a class=""text"" href=""https://oldschool.runescape.wiki/w/Template:Cannon?action=edit""><span title=""Edit this template"">e</span></a></div></div><span><a href=""/w/Dwarf_multicannon"" title=""Dwarf multicannon"">Dwarf multicannon</a></span></div></th></tr><tr class=""navbox-group""><td class=""navbox-group-title"">Parts</td><td class=""navbox-list"">
		<ul><li><span class=""plink-template""><a href=""/w/Cannon_stand"" title=""Cannon stand""><img alt=""Cannon stand.png"" src=""/images/Cannon_stand.png?39d34"" decoding=""async"" width=""28"" height=""27"" data-file-width=""28"" data-file-height=""27"" /></a></span><a href=""/w/Cannon_stand"" title=""Cannon stand"">Cannon stand</a></li>
		<li><span class=""plink-template""><a href=""/w/Cannon_base"" title=""Cannon base""><img alt=""Cannon base.png"" src=""/images/Cannon_base.png?3c432"" decoding=""async"" width=""22"" height=""29"" data-file-width=""22"" data-file-height=""29"" /></a></span><a class=""mw-selflink selflink"">Cannon base</a></li>
		<li><span class=""plink-template""><a href=""/w/Cannon_barrels"" title=""Cannon barrels""><img alt=""Cannon barrels.png"" src=""/images/Cannon_barrels.png?3c432"" decoding=""async"" width=""30"" height=""29"" data-file-width=""30"" data-file-height=""29"" /></a></span><a href=""/w/Cannon_barrels"" title=""Cannon barrels"">Cannon barrels</a></li>
		<li><span class=""plink-template""><a href=""/w/Cannon_furnace"" title=""Cannon furnace""><img alt=""Cannon furnace.png"" src=""/images/Cannon_furnace.png?3c432"" decoding=""async"" width=""27"" height=""27"" data-file-width=""27"" data-file-height=""27"" /></a></span><a href=""/w/Cannon_furnace"" title=""Cannon furnace"">Cannon furnace</a></li></ul></td></tr><tr class=""navbox-group""><td class=""navbox-group-title"">Ammunition</td><td class=""navbox-list"">
		<ul><li><span class=""plink-template""><a href=""/w/Cannonball"" title=""Cannonball""><img alt=""Cannonball.png"" src=""/images/Cannonball.png?3c432"" decoding=""async"" width=""23"" height=""21"" data-file-width=""23"" data-file-height=""21"" /></a></span><a href=""/w/Cannonball"" title=""Cannonball"">Cannonball</a></li>
		<li><span class=""plink-template""><a href=""/w/Granite_cannonball"" title=""Granite cannonball""><img alt=""Granite cannonball.png"" src=""/images/Granite_cannonball.png?fee90"" decoding=""async"" width=""23"" height=""21"" data-file-width=""23"" data-file-height=""21"" /></a></span><a href=""/w/Granite_cannonball"" title=""Granite cannonball"">Granite cannonball</a></li></ul></td></tr></tbody></table>
		<table class=""navbox nowraplinks mw-collapsible"" data-expandtext=""show"" data-navbox-name=""Dwarf Cannon"" data-collapsetext=""hide""><tbody><tr><th colspan=""2"" class=""navbox-title"" id=""navbox-title""><div class=""navbox-title-name-notplain""><div class=""navbar"" style=""float:left;text-align:left;width:6em""><div class=""plainlinks noprint"" style=""background-color:transparent;padding:0;font-weight:normal;font-size:xx-small;white-space:nowrap""><a href=""/w/Template:Dwarf_Cannon"" title=""Template:Dwarf Cannon""><span title=""View this template"">v</span></a>&#160;<span style=""font-size:80%"">&#8226;</span>&#160;<a class=""text"" href=""https://oldschool.runescape.wiki/w/Template_talk:Dwarf_Cannon""><span title=""Discussion about this template"">d</span></a>&#160;<span style=""font-size:80%"">&#8226;</span>&#160;<a class=""text"" href=""https://oldschool.runescape.wiki/w/Template:Dwarf_Cannon?action=edit""><span title=""Edit this template"">e</span></a></div></div><span><a href=""/w/Dwarf_Cannon"" title=""Dwarf Cannon"">Dwarf Cannon</a></span></div></th></tr><tr class=""navbox-group""><td class=""navbox-group-title"">NPCs</td><td class=""navbox-list"">
		<ul><li><span class=""plink-template""><a href=""/w/Captain_Lawgof"" title=""Captain Lawgof""><img alt=""Captain Lawgof chathead.png: Chat head image of Captain Lawgof"" src=""/images/thumb/Captain_Lawgof_chathead.png/26px-Captain_Lawgof_chathead.png?6a49a"" decoding=""async"" width=""26"" height=""35"" srcset=""/images/thumb/Captain_Lawgof_chathead.png/39px-Captain_Lawgof_chathead.png?6a49a 1.5x, /images/thumb/Captain_Lawgof_chathead.png/51px-Captain_Lawgof_chathead.png?6a49a 2x"" data-file-width=""70"" data-file-height=""95"" /></a></span><a href=""/w/Captain_Lawgof"" title=""Captain Lawgof"">Captain Lawgof</a></li>
		<li><span class=""plink-template""><a href=""/w/Lollk"" title=""Lollk""><img alt=""Lollk chathead.png: Chat head image of Lollk"" src=""/images/thumb/Lollk_chathead.png/25px-Lollk_chathead.png?a61b4"" decoding=""async"" width=""25"" height=""35"" srcset=""/images/thumb/Lollk_chathead.png/38px-Lollk_chathead.png?a61b4 1.5x, /images/thumb/Lollk_chathead.png/51px-Lollk_chathead.png?a61b4 2x"" data-file-width=""56"" data-file-height=""77"" /></a></span><a href=""/w/Lollk"" title=""Lollk"">Lollk</a></li>
		<li><a href=""/w/Gilob"" title=""Gilob"">Gilob</a></li>
		<li><span class=""plink-template""><a href=""/w/Nulodion"" title=""Nulodion""><img alt=""Nulodion chathead.png: Chat head image of Nulodion"" src=""/images/thumb/Nulodion_chathead.png/15px-Nulodion_chathead.png?7b09d"" decoding=""async"" width=""15"" height=""35"" srcset=""/images/thumb/Nulodion_chathead.png/22px-Nulodion_chathead.png?7b09d 1.5x, /images/thumb/Nulodion_chathead.png/30px-Nulodion_chathead.png?7b09d 2x"" data-file-width=""76"" data-file-height=""178"" /></a></span><a href=""/w/Nulodion"" title=""Nulodion"">Nulodion</a></li></ul></td></tr><tr class=""navbox-group""><td class=""navbox-group-title"">Items</td><td class=""navbox-list navbox-parent"" style=""padding:0""><table class=""navbox-subgroup nowraplinks"" data-expandtext=""show"" data-collapsetext=""hide""><tbody><tr class=""navbox-group navbox-group-split""><td class=""navbox-group-title-hidden"" colspan=""0"" style=""display:none""></td><td colspan=""2"" class=""navbox-list"">
		<ul><li><span class=""plink-template""><a href=""/w/Railing"" title=""Railing""><img alt=""Railing.png"" src=""/images/Railing.png?9a45f"" decoding=""async"" width=""23"" height=""25"" data-file-width=""23"" data-file-height=""25"" /></a></span><a href=""/w/Railing"" title=""Railing"">Railing</a></li>
		<li><span class=""plink-template""><a href=""/w/Dwarf_remains"" title=""Dwarf remains""><img alt=""Dwarf remains.png"" src=""/images/Dwarf_remains.png?5eb13"" decoding=""async"" width=""29"" height=""30"" data-file-width=""29"" data-file-height=""30"" /></a></span><a href=""/w/Dwarf_remains"" title=""Dwarf remains"">Dwarf remains</a></li>
		<li><span class=""plink-template""><a href=""/w/Toolkit"" title=""Toolkit""><img alt=""Toolkit.png"" src=""/images/Toolkit.png?b77a4"" decoding=""async"" width=""29"" height=""27"" data-file-width=""29"" data-file-height=""27"" /></a></span><a href=""/w/Toolkit"" title=""Toolkit"">Toolkit</a></li>
		<li><span class=""plink-template""><a href=""/w/Ammo_mould"" title=""Ammo mould""><img alt=""Ammo mould.png"" src=""/images/Ammo_mould.png?8d9e1"" decoding=""async"" width=""29"" height=""26"" data-file-width=""29"" data-file-height=""26"" /></a></span><a href=""/w/Ammo_mould"" title=""Ammo mould"">Ammo mould</a></li>
		<li><span class=""plink-template""><a href=""/w/Instruction_manual"" title=""Instruction manual""><img alt=""Instruction manual.png"" src=""/images/Instruction_manual.png?13f14"" decoding=""async"" width=""28"" height=""27"" data-file-width=""28"" data-file-height=""27"" /></a></span><a href=""/w/Instruction_manual"" title=""Instruction manual"">Instruction manual</a></li>
		<li><span class=""plink-template""><a href=""/w/Nulodion%27s_notes"" title=""Nulodion&#39;s notes""><img alt=""Nulodion&#39;s notes.png"" src=""/images/Nulodion%27s_notes.png?b81d4"" decoding=""async"" width=""28"" height=""27"" data-file-width=""28"" data-file-height=""27"" /></a></span><a href=""/w/Nulodion%27s_notes"" title=""Nulodion&#39;s notes"">Nulodion's notes</a></li></ul></td></tr><tr class=""navbox-group""><td class=""navbox-group-title""><a href=""/w/Dwarf_multicannon"" title=""Dwarf multicannon"">Dwarf multicannon</a></td><td class=""navbox-list"">
		<ul><li><span class=""plink-template""><a href=""/w/Cannonball"" title=""Cannonball""><img alt=""Cannonball.png"" src=""/images/Cannonball.png?3c432"" decoding=""async"" width=""23"" height=""21"" data-file-width=""23"" data-file-height=""21"" /></a></span><a href=""/w/Cannonball"" title=""Cannonball"">Cannonball</a></li>
		<li><span class=""plink-template""><a href=""/w/Cannon_barrels"" title=""Cannon barrels""><img alt=""Cannon barrels.png"" src=""/images/Cannon_barrels.png?3c432"" decoding=""async"" width=""30"" height=""29"" data-file-width=""30"" data-file-height=""29"" /></a></span><a href=""/w/Cannon_barrels"" title=""Cannon barrels"">Cannon barrels</a></li>
		<li><span class=""plink-template""><a href=""/w/Cannon_base"" title=""Cannon base""><img alt=""Cannon base.png"" src=""/images/Cannon_base.png?3c432"" decoding=""async"" width=""22"" height=""29"" data-file-width=""22"" data-file-height=""29"" /></a></span><a class=""mw-selflink selflink"">Cannon base</a></li>
		<li><span class=""plink-template""><a href=""/w/Cannon_furnace"" title=""Cannon furnace""><img alt=""Cannon furnace.png"" src=""/images/Cannon_furnace.png?3c432"" decoding=""async"" width=""27"" height=""27"" data-file-width=""27"" data-file-height=""27"" /></a></span><a href=""/w/Cannon_furnace"" title=""Cannon furnace"">Cannon furnace</a></li>
		<li><span class=""plink-template""><a href=""/w/Cannon_stand"" title=""Cannon stand""><img alt=""Cannon stand.png"" src=""/images/Cannon_stand.png?39d34"" decoding=""async"" width=""28"" height=""27"" data-file-width=""28"" data-file-height=""27"" /></a></span><a href=""/w/Cannon_stand"" title=""Cannon stand"">Cannon stand</a></li></ul></td></tr></tbody></table></td></tr><tr class=""navbox-group""><td class=""navbox-group-title"">Locations</td><td class=""navbox-list"">
		<ul><li><a href=""/w/Coal_Trucks"" title=""Coal Trucks"">Coal Trucks</a></li>
		<li><a href=""/w/Goblin_Cave"" title=""Goblin Cave"">Goblin Cave</a></li>
		<li><a href=""/w/Dwarven_Mine"" title=""Dwarven Mine"">Dwarven Mine</a></li></ul></td></tr><tr class=""navbox-group""><td class=""navbox-group-title"">Related</td><td class=""navbox-list"">
		<ul><li><a href=""/w/Dwarf_Cannon/Quick_guide"" title=""Dwarf Cannon/Quick guide"">Quick Guide</a></li>
		<li><a href=""/w/Transcript:Dwarf_Cannon"" title=""Transcript:Dwarf Cannon"">Transcript</a></li></ul></td></tr></tbody></table>
		<!-- 
		NewPP limit report
		Parsed by mediawiki‐58f8ddccb5‐qmjt4
		Cached time: 20220114235059
		Cache expiry: 86400
		Dynamic content: false
		Complications: []
		[SMW] In‐text annotation parser time: 0 seconds
		CPU time usage: 0.144 seconds
		Real time usage: 0.261 seconds
		Preprocessor visited node count: 542/1000000
		Post‐expand include size: 32758/2097152 bytes
		Template argument size: 1018/2097152 bytes
		Highest expansion depth: 9/40
		Expensive parser function count: 0/100
		Unstrip recursion depth: 0/20
		Unstrip post‐expand size: 0/5000000 bytes
		Lua time usage: 0.069/10.000 seconds
		Lua memory usage: 3490926/367001600 bytes
		-->
		<!--
		Transclusion expansion time report (%,ms,calls,template)
		100.00%  184.167      1 -total
		 48.21%   88.789      1 Template:Store_locations_list
		 29.35%   54.045      1 Template:Infobox_Item
		 11.01%   20.285      3 Template:Navbox
		  7.30%   13.449      1 Template:External
		  7.19%   13.239      1 Template:Dwarf_Cannon
		  5.92%   10.906      1 Template:Cannon
		  1.84%    3.390      1 Template:Ctg
		  1.78%    3.275      1 Template:NoCoins
		  1.59%    2.930     17 Template:Plink
		-->

		<!-- Saved in parser cache with key en_osrswiki:pcache:idhash:19175-0!canonical and timestamp 20220114235059 and revision id 14068091. Serialized with PHP.
		 -->
		</div>
		<div class=""printfooter"">Retrieved from ‘<a dir=""ltr"" href=""https://oldschool.runescape.wiki/w/Cannon_base?oldid=14068091"">https://oldschool.runescape.wiki/w/Cannon_base?oldid=14068091</a>’</div></div>
				<div id=""catlinks"" class=""catlinks"" data-mw=""interface""><div id=""mw-normal-catlinks"" class=""mw-normal-catlinks""><a href=""/w/Special:Categories"" title=""Special:Categories"">Categories</a>: <ul><li><a href=""/w/Category:Items"" title=""Category:Items"">Items</a></li><li><a href=""/w/Category:Tradeable_items"" title=""Category:Tradeable items"">Tradeable items</a></li><li><a href=""/w/Category:Grand_Exchange_items"" title=""Category:Grand Exchange items"">Grand Exchange items</a></li><li><a href=""/w/Category:Members%27_items"" title=""Category:Members&#039; items"">Members' items</a></li><li><a href=""/w/Category:Quest_items"" title=""Category:Quest items"">Quest items</a></li><li><a href=""/w/Category:Dwarf_Cannon"" title=""Category:Dwarf Cannon"">Dwarf Cannon</a></li></ul></div></div>
			</div>
		</div>

		<div id=""mw-navigation"">
			<h2>Navigation menu</h2>
			<div id=""mw-head"">
				<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-personal"" class=""mw-portlet mw-portlet-personal vector-menu"" aria-labelledby=""p-personal-label"" role=""navigation"" 
			 >
			<h3 id=""p-personal-label"" class=""vector-menu-heading"">
				<span>Personal tools</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""pt-userpage""><a href=""/w/User:Welfare_PvM"" dir=""auto"" title=""Your user page [.]"" accesskey=""."">Welfare PvM</a></li><li id=""pt-notifications-alert""><a class=""mw-echo-notifications-badge mw-echo-notification-badge-nojs oo-ui-icon-bell mw-echo-notifications-badge-all-read"" href=""/w/Special:Notifications"" data-counter-num=""0"" data-counter-text=""0"" title=""Your alerts"">Alerts (0)</a></li><li id=""pt-notifications-notice""><a class=""mw-echo-notifications-badge mw-echo-notification-badge-nojs oo-ui-icon-tray mw-echo-notifications-badge-all-read"" href=""/w/Special:Notifications"" data-counter-num=""0"" data-counter-text=""0"" title=""Your notices"">Notices (0)</a></li><li id=""pt-mytalk""><a href=""/w/User_talk:Welfare_PvM"" title=""Your talk page [n]"" accesskey=""n"">Talk</a></li><li id=""pt-preferences""><a href=""/w/Special:Preferences"" title=""Your preferences"">Preferences</a></li><li id=""pt-watchlist""><a href=""/w/Special:Watchlist"" title=""A list of pages you are monitoring for changes [l]"" accesskey=""l"">Watchlist</a></li><li id=""pt-mycontris""><a href=""/w/Special:Contributions/Welfare_PvM"" title=""A list of your contributions [y]"" accesskey=""y"">Contributions</a></li><li id=""pt-logout""><a href=""/w/Special:UserLogout?returnto=Cannon+base"" data-mw=""interface"" title=""Log out"">Log out</a></li></ul>
				
			</div>
		</nav>

				<div id=""left-navigation"">
					<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-namespaces"" class=""mw-portlet mw-portlet-namespaces vector-menu vector-menu-tabs"" aria-labelledby=""p-namespaces-label"" role=""navigation"" 
			 >
			<h3 id=""p-namespaces-label"" class=""vector-menu-heading"">
				<span>Namespaces</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""ca-nstab-main"" class=""selected""><a href=""/w/Cannon_base"" title=""View the content page [c]"" accesskey=""c"">Article</a></li><li id=""ca-talk""><a href=""/w/Talk:Cannon_base"" rel=""discussion"" title=""Discussion about the content page [t]"" accesskey=""t"">Discussion</a></li></ul>
				
			</div>
		</nav>

					<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-variants"" class=""mw-portlet mw-portlet-variants emptyPortlet vector-menu vector-menu-dropdown"" aria-labelledby=""p-variants-label"" role=""navigation"" 
			 >
			<input type=""checkbox"" class=""vector-menu-checkbox"" aria-labelledby=""p-variants-label"" />
			<h3 id=""p-variants-label"" class=""vector-menu-heading"">
				<span>Variants</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""></ul>
				
			</div>
		</nav>

				</div>
				<div id=""right-navigation"">
					<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-views"" class=""mw-portlet mw-portlet-views vector-menu vector-menu-tabs"" aria-labelledby=""p-views-label"" role=""navigation"" 
			 >
			<h3 id=""p-views-label"" class=""vector-menu-heading"">
				<span>Views</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""ca-view"" class=""selected""><a href=""/w/Cannon_base"">Read</a></li><li id=""ca-ve-edit""><a href=""/w/Cannon_base?veaction=edit"" title=""Edit this page [v]"" accesskey=""v"">Edit</a></li><li id=""ca-edit"" class=""collapsible""><a href=""/w/Cannon_base?action=edit"" title=""Edit this page [e]"" accesskey=""e"">Edit source</a></li><li id=""ca-history""><a href=""/w/Cannon_base?action=history"" title=""Past revisions of this page [h]"" accesskey=""h"">History</a></li><li id=""ca-watch"" class=""icon mw-watchlink""><a href=""/w/Cannon_base?action=watch"" data-mw=""interface"" title=""Add this page to your watchlist [w]"" accesskey=""w"">Watch</a></li></ul>
				
			</div>
		</nav>

					<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-cactions"" class=""mw-portlet mw-portlet-cactions vector-menu vector-menu-dropdown"" aria-labelledby=""p-cactions-label"" role=""navigation"" 
			 >
			<input type=""checkbox"" class=""vector-menu-checkbox"" aria-labelledby=""p-cactions-label"" />
			<h3 id=""p-cactions-label"" class=""vector-menu-heading"">
				<span>More</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""ca-move""><a href=""/w/Special:MovePage/Cannon_base"" title=""Move this page [m]"" accesskey=""m"">Move</a></li><li id=""ca-purge"" class=""is-disabled""><a href=""/w/Cannon_base?action=purge"">Refresh</a></li></ul>
				
			</div>
		</nav>

					<div id=""p-search"" role=""search"" >
			<h3 >
				<label for=""searchInput"">Search</label>
			</h3>
			<form action=""/"" id=""searchform"">
				<div id=""simpleSearch"" data-search-loc=""header-navigation"">
					<input type=""search"" name=""search"" placeholder=""Search the Old School RuneScape Wiki"" autocapitalize=""sentences"" title=""Search the wiki [f]"" accesskey=""f"" id=""searchInput""/>
					<input type=""hidden"" name=""title"" value=""Special:Search""/>
					<input type=""submit"" name=""fulltext"" value=""Search"" title=""Search pages for this text"" id=""mw-searchButton"" class=""searchButton mw-fallbackSearchButton""/>
					<input type=""submit"" name=""go"" value=""Go"" title=""Go to a page with this exact name if it exists"" id=""searchButton"" class=""searchButton""/>
				</div>
			</form>
		</div>

				</div>
			</div>
			
		<div id=""mw-panel"">
			<div id=""p-logo"" role=""banner"">
				<a class=""mw-wiki-logo"" href=""/""
					title=""Visit the main page""></a>
			</div>
			<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-Discord"" class=""mw-portlet mw-portlet-Discord vector-menu vector-menu-portal portal"" aria-labelledby=""p-Discord-label"" role=""navigation"" 
			 >
			<h3 id=""p-Discord-label"" class=""vector-menu-heading"">
				<span>Discord</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""n-Discord""><a href=""https://discord.gg/HWhxYsP"" rel=""nofollow"" target=""_blank"">Discord</a></li></ul>
				
			</div>
		</nav>

			<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-Navigation"" class=""mw-portlet mw-portlet-Navigation vector-menu vector-menu-portal portal"" aria-labelledby=""p-Navigation-label"" role=""navigation"" 
			 >
			<h3 id=""p-Navigation-label"" class=""vector-menu-heading"">
				<span>Navigation</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""n-Main-page""><a href=""/"">Main page</a></li><li id=""n-About-us""><a href=""/w/RuneScape:About"">About us</a></li><li id=""n-New-files""><a href=""/w/Special:NewFiles"">New files</a></li><li id=""n-Random-page""><a href=""/w/Special:Random/main"">Random page</a></li><li id=""n-Contact-us""><a href=""/w/RuneScape:Contact_us"">Contact us</a></li></ul>
				
			</div>
		</nav>
		<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-Recent_changes"" class=""mw-portlet mw-portlet-Recent_changes emptyPortlet vector-menu vector-menu-portal portal"" aria-labelledby=""p-Recent_changes-label"" role=""navigation"" 
			 >
			<h3 id=""p-Recent_changes-label"" class=""vector-menu-heading"">
				<span>Recent changes</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""></ul>
				
			</div>

		<div class=""rc-sidebar-item"">
			<a class=""rc-sidebar-page"" href=""/w/Lilly"">Lilly</a>
			<p class=""rc-sidebar-user"">
				<a href=""/?diff=14229164"">1h <span class=""rc-sidebar-ago"">ago</span></a>&nbsp;-
				<a href=""/w/Special:Contributions/Lotenn"">Lotenn</a>
			</p>
		</div>
		<div class=""rc-sidebar-item"">
			<a class=""rc-sidebar-page"" href=""/w/Wilderness"">Wilderness</a>
			<p class=""rc-sidebar-user"">
				<a href=""/?diff=14229161"">1h <span class=""rc-sidebar-ago"">ago</span></a>&nbsp;-
				<a href=""/w/Special:Contributions/2A02%3AC7F%3A3224%3A3F00%3ABC51%3A656C%3A21DB%3A1720"">[anonymous]</a>
			</p>
		</div>
		<div class=""rc-sidebar-item"">
			<a class=""rc-sidebar-page"" href=""/w/Cosmic_rune"">Cosmic rune</a>
			<p class=""rc-sidebar-user"">
				<a href=""/?diff=14229160"">1h <span class=""rc-sidebar-ago"">ago</span></a>&nbsp;-
				<a href=""/w/Special:Contributions/Logg"">Logg</a>
			</p>
		</div>
		<div class=""rc-sidebar-item"">
			<a class=""rc-sidebar-page"" href=""/w/Shattered_Relics_League%2FGuide"">Shattered Relics League/Guide</a>
			<p class=""rc-sidebar-user"">
				<a href=""/?diff=14229159"">2h <span class=""rc-sidebar-ago"">ago</span></a>&nbsp;-
				<a href=""/w/Special:Contributions/TheJenga"">TheJenga</a>
			</p>
		</div>
		<div class=""rc-sidebar-item rc-sidebar-more"">
		    <a class=""rc-sidebar-page"" href=""/w/Special:RecentChanges"">Show more...</a>
		</div></nav>
		<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-Guides"" class=""mw-portlet mw-portlet-Guides vector-menu vector-menu-portal portal"" aria-labelledby=""p-Guides-label"" role=""navigation"" 
			 >
			<h3 id=""p-Guides-label"" class=""vector-menu-heading"">
				<span>Guides</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""n-Recent-updates""><a href=""/w/2022"">Recent updates</a></li><li id=""n-List-of-quests""><a href=""/w/List_of_quests"">List of quests</a></li><li id=""n-Achievement-Diaries""><a href=""/w/Achievement_Diary"">Achievement Diaries</a></li><li id=""n-Combat-Achievements""><a href=""/w/Combat_Achievements"">Combat Achievements</a></li><li id=""n-Skill-training""><a href=""/w/Skill_training_guides"">Skill training</a></li><li id=""n-Money-making""><a href=""/w/Money_making_guide"">Money making</a></li><li id=""n-Calculators""><a href=""/w/Calculators"">Calculators</a></li><li id=""n-Treasure-Trails""><a href=""/w/Treasure_Trails/Guide"">Treasure Trails</a></li><li id=""n-New-player-guide""><a href=""/w/New_player_guide"">New player guide</a></li></ul>
				
			</div>
		</nav>
		<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-Community"" class=""mw-portlet mw-portlet-Community vector-menu vector-menu-portal portal"" aria-labelledby=""p-Community-label"" role=""navigation"" 
			 >
			<h3 id=""p-Community-label"" class=""vector-menu-heading"">
				<span>Community</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""n-User-help""><a href=""/w/RuneScape:User_help"">User help</a></li><li id=""n-Active-discussions""><a href=""/w/RuneScape:Active_discussions"">Active discussions</a></li><li id=""n-OSRS-Wiki-Clan""><a href=""/w/RuneScape:Clan_Chat"">OSRS Wiki Clan</a></li><li id=""n-Frequently-asked-questions""><a href=""/w/RuneScape:Frequently_asked_questions"">Frequently asked questions</a></li><li id=""n-Policies""><a href=""/w/RuneScape:Policies"">Policies</a></li></ul>
				
			</div>
		</nav>
		<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-More_RuneScape"" class=""mw-portlet mw-portlet-More_RuneScape vector-menu vector-menu-portal portal"" aria-labelledby=""p-More_RuneScape-label"" role=""navigation"" 
			 >
			<h3 id=""p-More_RuneScape-label"" class=""vector-menu-heading"">
				<span>More RuneScape</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""n-RuneScape-Wiki""><a href=""https://runescape.wiki/w/RuneScape_Wiki"">RuneScape Wiki</a></li><li id=""n-RSC-Wiki""><a href=""https://classic.runescape.wiki/w/RuneScape_Classic_Wiki"">RSC Wiki</a></li></ul>
				
			</div>
		</nav>
		<!-- Please do not use role attribute as CSS selector, it is deprecated. -->
		<nav id=""p-tb"" class=""mw-portlet mw-portlet-tb vector-menu vector-menu-portal portal"" aria-labelledby=""p-tb-label"" role=""navigation"" 
			 >
			<h3 id=""p-tb-label"" class=""vector-menu-heading"">
				<span>Tools</span>
			</h3>
			<div class=""vector-menu-content"">
				<ul class=""vector-menu-content-list""><li id=""t-whatlinkshere""><a href=""/w/Special:WhatLinksHere/Cannon_base"" title=""A list of all wiki pages that link here [j]"" accesskey=""j"">What links here</a></li><li id=""t-recentchangeslinked""><a href=""/w/Special:RecentChangesLinked/Cannon_base"" rel=""nofollow"" title=""Recent changes in pages linked from this page [k]"" accesskey=""k"">Related changes</a></li><li id=""t-upload""><a href=""/w/Special:Upload"" title=""Upload files [u]"" accesskey=""u"">Upload file</a></li><li id=""t-specialpages""><a href=""/w/Special:SpecialPages"" title=""A list of all special pages [q]"" accesskey=""q"">Special pages</a></li><li id=""t-print""><a href=""javascript:print();"" rel=""alternate"" title=""Printable version of this page [p]"" accesskey=""p"">Printable version</a></li><li id=""t-permalink""><a href=""/w/Cannon_base?oldid=14068091"" title=""Permanent link to this revision of the page"">Permanent link</a></li><li id=""t-info""><a href=""/w/Cannon_base?action=info"" title=""More information about this page"">Page information</a></li><li id=""t-smwbrowselink""><a href=""/w/Special:Browse/:Cannon-5Fbase"" rel=""search"">Browse properties</a></li></ul>
				
			</div>
		</nav>

			
		</div>

		</div>
		<footer id=""footer"" class=""mw-footer"" role=""contentinfo"" >
			<ul id=""footer-info"" >
			<li id=""footer-info-lastmod""> This page was last modified on 3 May 2021, at 14:25.</li>
			<li id=""footer-info-copyright"">Content on this site is licensed under <a class=""external"" rel=""nofollow"" href=""https://creativecommons.org/licenses/by-nc-sa/3.0/"">CC BY-NC-SA 3.0</a>; <a href=""https://meta.weirdgloop.org/w/Project:Copyrights"">additional terms apply</a>.
		<br /><i>RuneScape</i> and <i>RuneScape Old School</i> are the trademarks of <a href=""http://jagex.com"">Jagex Limited</a> and are used with the permission of Jagex.</li>
		</ul>

			<ul id=""footer-places"" >
			<li id=""footer-places-privacy""><a href=""https://weirdgloop.org/privacy"" class=""extiw"" title=""wg:privacy"">Privacy policy</a></li>
			<li id=""footer-places-about""><a href=""/w/RuneScape:About"" title=""RuneScape:About"">About the Old School RuneScape Wiki</a></li>
			<li id=""footer-places-disclaimer""><a href=""/w/RuneScape:General_disclaimer"" title=""RuneScape:General disclaimer"">Disclaimers</a></li>
			<li id=""footer-places-tou""><a href=""https://weirdgloop.org/terms"" class=""extiw"" title=""wg:terms"">Terms of Use</a></li>
			<li id=""footer-places-contact""><a href=""/w/Special:Contact"" title=""Special:Contact"">Contact Weird Gloop</a></li>
			<li id=""footer-places-mobileview""><a href=""https://oldschool.runescape.wiki/w/Cannon_base?mobileaction=toggle_view_mobile"" class=""noprint stopMobileRedirectToggle"">Mobile view</a></li>
		</ul>

			<ul id=""footer-icons"" class=""noprint"">
			<li id=""footer-copyrightico""><a href=""https://creativecommons.org/licenses/by-nc-sa/3.0/"" target=""_blank""><img src=""https://meta.weirdgloop.org/images/Weird_Gloop_footer.png"" alt=""CC BY-NC-SA 3.0"" srcset=""https://meta.weirdgloop.org/images/Weird_Gloop_footer@2x.png 2x"" width=""88"" height=""31"" loading=""lazy""/></a></li>
			<li id=""footer-poweredbyico""><a href=""https://weirdgloop.org"" target=""_blank""><img src=""https://meta.weirdgloop.org/images/Weird_Gloop_footer.png"" srcset=""https://meta.weirdgloop.org/images/Weird_Gloop_footer@2x.png 2x"" alt=""A Weird Gloop wiki"" width=""88"" height=""31"" loading=""lazy""/></a></li>
		</ul>

		</footer>


		<script async="""" src=""https://www.googletagmanager.com/gtag/js?id=UA-126479006-1""></script><script>
		window.dataLayer=window.dataLayer||[];function gtag(){dataLayer.push(arguments);}gtag('js',new Date());gtag('config','UA-126479006-1')
		</script>

		<script>(RLQ=window.RLQ||[]).push(function(){mw.config.set({""wgPageParseReport"":{""smw"":{""limitreport-intext-parsertime"":0},""limitreport"":{""cputime"":""0.144"",""walltime"":""0.261"",""ppvisitednodes"":{""value"":542,""limit"":1000000},""postexpandincludesize"":{""value"":32758,""limit"":2097152},""templateargumentsize"":{""value"":1018,""limit"":2097152},""expansiondepth"":{""value"":9,""limit"":40},""expensivefunctioncount"":{""value"":0,""limit"":100},""unstrip-depth"":{""value"":0,""limit"":20},""unstrip-size"":{""value"":0,""limit"":5000000},""timingprofile"":[""100.00%  184.167      1 -total"","" 48.21%   88.789      1 Template:Store_locations_list"","" 29.35%   54.045      1 Template:Infobox_Item"","" 11.01%   20.285      3 Template:Navbox"",""  7.30%   13.449      1 Template:External"",""  7.19%   13.239      1 Template:Dwarf_Cannon"",""  5.92%   10.906      1 Template:Cannon"",""  1.84%    3.390      1 Template:Ctg"",""  1.78%    3.275      1 Template:NoCoins"",""  1.59%    2.930     17 Template:Plink""]},""scribunto"":{""limitreport-timeusage"":{""value"":""0.069"",""limit"":""10.000""},""limitreport-memusage"":{""value"":3490926,""limit"":367001600},""limitreport-logs"":""Searching for shops that sell: Cannon base\nSMW (store locations list): entries: 1, time elapsed: 21.740 ms.\n""},""cachereport"":{""origin"":""mediawiki-58f8ddccb5-qmjt4"",""timestamp"":""20220114235059"",""ttl"":86400,""transientcontent"":false}}});mw.config.set({""wgBackendResponseTime"":193,""wgHostname"":""mediawiki-58f8ddccb5-rfv4d""});});</script>
		<script defer src=""https://static.cloudflareinsights.com/beacon.min.js/v652eace1692a40cfa3763df669d7439c1639079717194"" integrity=""sha512-Gi7xpJR8tSkrpF7aordPZQlW2DLtzUlZcumS8dMQjwDHEnw9I7ZLyiOj/6tZStRBGtGgN6ceN6cMH8z7etPGlw=="" data-cf-beacon='{""rayId"":""6cdac59c190e30bc"",""token"":""6348a5ceb9674fe390473560fffff798"",""version"":""2021.12.0"",""si"":100}' crossorigin=""anonymous""></script>
		</body></html>";
    }
}