#pragma checksum "E:\GitHub\HolidayChecklist\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0c31986a6608cc7faafc3b4e7eeefe08a4484af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HolidayChecklist.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(HolidayChecklist.Pages.Pages_Index), null)]
namespace HolidayChecklist.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\GitHub\HolidayChecklist\Pages\_ViewImports.cshtml"
using HolidayChecklist;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c31986a6608cc7faafc3b4e7eeefe08a4484af", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f90e6b79a2498bf38006f64a6095ea7bf4a53d3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\GitHub\HolidayChecklist\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 120, true);
            WriteLiteral("<div class=\"container\" id=\"App\">\r\n    <div id = \"searchForm\" class = \"container\" style = \"padding-top: 20px;\">\r\n        ");
            EndContext();
            BeginContext(191, 655, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faab2ac22b2840c099cdbae939d2b1de", async() => {
                BeginContext(197, 642, true);
                WriteLiteral(@"
            <div class = ""col-xs-12 col-md-8"">
                <input v-model=""searchTerm"" class=""form-control form-control"" type=""text"" placeholder=""Search for a show...""v-on:keyup=""searchShow()"">
            </div>
            <div class = ""col-md-2"">
                <button  v-if=""desktop"" id = ""searchSubmit"" type = ""submit"" class = ""btn btn-primary"" v-on:click.stop.prevent='searchShow()'>Find</button>
            </div>
            <div class = ""col-md-2"">
                <button v-if=""desktop"" id = ""searchCancel"" class = ""btn btn-default"" v-on:click.stop.prevent=""emptySearch()"">Back</button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(846, 2863, true);
            WriteLiteral(@"
    </div>
    <div  v-show =""showSearchResults"" class=""container"" stle=""z-index: 3;"">
      <div class=""row text-center text-left"">
        <div class=""col-xs-12 col-md-8"">
          <div class=""list-group my-3"">
            <a v-for = ""item in searchResults""v-on:click.stop.prevent=""showDetails(item)"" href=""#"" class=""list-group-item list-group-item-action d-flex   align-items-center"">
                <div class =""row"">
                    <h4 v-if=""desktop"">{{item.name}} ({{item.first_air_date}})</h4>
                    <p v-else class=""mb-0 text-center"">{{item.name}} - ({{item.first_air_date.substring(0,4)}})</p>
                    <img v-if=""desktop"" class=""d-block float-right img-thumbnail img-fluid"" v-bind:src=""imgURL + item.poster_path"" width=""60"" height=""60"" > 
                    <button class=""btn btn-danger""v-if=""desktop""><span class=""glyphicon glyphicon-heart"" aria-hidden=""true"" style =""color:white;""></span></button>
                    <button class=""btn btn-info""v-if=""desktop""><spa");
            WriteLiteral(@"n class=""glyphicon glyphicon-info-sign"" aria-hidden=""true"" style =""color:white;""></span></button>
                </div>
            </a>
          </div>
        </div>  
      </div>
    </div>
    <div v-if = ""showHighlightedShow"" class = ""container"" style =""background-color: white; margin-top: 20px;"">
        <div class=""col-xs-12 col-md-12"">
            <div class=""row"">
                <div class = ""col-xs-10"">
                    <h3 style=""text-align:center;"">{{highlightedShow.name}}</h3>
                </div>
                <div class = ""col-xs-2""> <button class=""btn btn-default""v-if=""desktop""><span class=""glyphicon glyphicon-remove"" aria-hidden=""true"" style =""color:white;""></span></button></div>
            </div>
            <div class=""row"">
                <div class=""col-xs-4"" >
                    <div class=""row"">
                        <img v-bind:src=""imgURL + highlightedShow.poster_path"" width=""100%"" style=""border-radius: 10px;""/>
                    </div>
          ");
            WriteLiteral(@"          <div class=""row"">
                        <div class=""col-xs-12""><button v-on:click=""saveShow(highlightedShow)"" class=""btn btn-danger"" style=""width:100%; margin-top:10px""><span class=""glyphicon glyphicon-heart"" aria-hidden=""true"" style =""color:white;""></span></button></div>
                    </div>
                </div>
                <div class=""col-xs-8"">
                    <p>First Air Date: {{highlightedShow.first_air_date}}</p>
                    <p>{{highlightedShow.overview}}</p>
                </div>
            </div>
            <div class=""row"">
                <span><button class=""btn btn-default"" style=""width:100%;margin-bottom:10px;"" v-on:click.stop.prevent=""emptySearch()"">Cancel</button></span>
            </div>
        </div>
        
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3727, 9395, true);
                WriteLiteral(@"
    <script>
    var ItemsVue = new Vue({
            el: '#App',
            data: {
                desktop: false,
                searchTerm: """",
                searchResults: """",
                highlightedShow: """",
                savedShow:{ 
                    ShowID: 0,
                    ShowTitle: """",
                    ShowBackdropPath: """",
                    ShowOverview:"""",
                    SeasonNumber: 0,
                    EpisodeNumber: 0,
                    EpisodeAirDate: ""1700-01-01"",
                    EpisodeTitle: """",
                    EpisodeOverview: """",
                },
                ajaxSeasons: [{
                    id: 0,
                    episodes:[] ,
                    NumberOfSeasons: 0,
                    Season: 0
                }],
                ajaxEpisodes: [{
                    ShowID: 0,
                    SeasonNumber: 0,
                    ShowTitle: """",
                    ShowBackdropPath: """",
            ");
                WriteLiteral(@"        ShowOverview: """",
                    EpisodeAirDate: """",
                    EpisodeNumber: 0,
                    EpisodeTitle: """",
                    EpisodeOverview: """"
                }],
                episodes: [] ,
                showSearchResults: false,
                showHighlightedShow: false,
                baseURL: ""https://api.themoviedb.org/3/"",
                imgURL: ""https://image.tmdb.org/t/p/w200"",
                apiKEY: ""api_key=dfb21457261ef1c427601ffcefc3da80""
            },
            
            mounted: function () {
            
               
            },
            methods: { 
                searchShow: function(searchTerm){
                    var self = this;
                    
                    if(self.searchTerm.length>=2){
                        self.showSearchResults = true;
                        $.ajax({
                        url: self.baseURL + ""search/tv?""+ self.apiKEY +""&language=en-US&query="" + self.searchTerm + ""&");
                WriteLiteral(@"page=1"",
                        dataType: 'json',
                        contentType: 'application/json',
                        method: 'GET',
                        success: function (data) {
                            self.searchResults = data.results.sort(function(a,b){
                                return b.popularity - a.popularity;
                            }).slice(0,3);
                        },
                        error: function (error) {
                            console.log(error);
                            alert(""Oh no! We couldn't find your shows. D:"");
                        }
                        });
                    }
                    else{
                        self.showSearchResults = false;
                    }
                },
                emptySearch: function(){
                    var self = this;
                    self.searchResults = '';
                    self.searchTerm = '';
                    self.showSearchResults =");
                WriteLiteral(@" false;
                    self.showHighlightedShow = false;
                },
                showDetails: function(item){
                    var self = this;
                    self.showSearchResults = false;
                    $.ajax({
                        url: self.baseURL + ""tv/"" + item.id + ""?""+ self.apiKEY +""&language=en-US"",
                        dataType: 'json',
                        contentType: 'application/json',
                        method: 'GET',
                        success: function (show) {
                            self.ajaxShowDetails = show;
                            self.highlightedShow = show;
                        },
                        error: function (error) {
                            console.log(error);
                            alert(""Oh no! We couldn't find that show. D:"");
                        }
                    });
                    self.showHighlightedShow = true;
                },
                getSeasonDetails:");
                WriteLiteral(@" function(id,season){
                    var self = this;
                    $.ajax({
                        url: self.baseURL + ""tv/"" + id + ""/season/"" + season +""?""+ self.apiKEY +""&language=en-US"",
                        dataType: 'json',
                        contentType: 'application/json',
                        method: 'GET',
                        success: function (season) {

                        },
                        error: function (error) {
                            console.log(error);
                            alert(""Oh no! We couldn't find those episodes. D:"");
                        }
                    });
                },
                saveShow: function(item){
                    var self = this;
                    (function(){
                    for(var i = 0;i < self.highlightedShow.number_of_seasons;i++){
                        (function(){
                            var seasonnum = i;
                            setTimeout(function(){
 ");
                WriteLiteral(@"                               $.ajax({
                                    url: self.baseURL + ""tv/"" + item.id + ""/season/"" + (seasonnum+1) +""?""+ self.apiKEY +""&language=en-US"",
                                    dataType: 'json',
                                    contentType: 'application/json',
                                    method: 'GET',
                                    success: function (season) {
                                        
                                        for(var j = 0;j < 10;j++){
                                            (function(){
                                                var episode = j;
                                                setTimeout(function(){
                                                    console.log(episode);
                                                },1000);
                                            })();
                                        };
                                        newEpisode = {
          ");
                WriteLiteral(@"                                  /*
                                            id: item.id,
                                            episodes: season.episodes,
                                            NumberOfSeasons: season.number_of_episodes,
                                            Season: season.season_number,
                                            ShowID: 0,
                                            */

                                            SeasonNumber: seasonnum + 1,
                                            ShowTitle: item.name,
                                            ShowBackdropPath: item.backdrop_path,
                                            ShowOverview: item.overview,
                                            EpisodeAirDate: """",
                                            EpisodeNumber: 0,
                                            EpisodeTitle: """",
                                            EpisodeOverview: """"
                                ");
                WriteLiteral(@"        }
                                        //self.ajaxEpisodes.push(newEpisode);
                                        console.log(season.name);
                                    },
                                    error: function (error) {
                                        console.log(error);
                                        alert(""Oh no! We couldn't find those episodes. D:"");
                                    }
                                });
                            },1000);
                        })();
                    }}).then
/*
                    for(var i = 0;i < item.number_of_seasons ;i++){
                        (function(){
                            var season = i;
                            function(){
                                console.log(season);
                                $.ajax({
                                    url: self.baseURL + ""tv/"" + item.id + ""/season/"" + season +""?""+ self.apiKEY +""&language=en-US"",
        ");
                WriteLiteral(@"                            dataType: 'json',
                                    contentType: 'application/json',
                                    method: 'GET',
                                    success: function (season) {
                                        self.ajaxSeasons.id = item.id;
                                        self.ajaxSeasons.CurrentSeason = season;
                                        self.ajaxSeasons.NumberOfSeasons = item.number_of_seasons;
                                        self.ajaxSeasons.episodes = season.episodes;
                                        console.log(self.ajaxSeasons);
                                    },
                                    error: function (error) {
                                        console.log(error);
                                        alert(""Oh no! We couldn't find those episodes. D:"");
                                    }
                                });
                                console.log");
                WriteLiteral("(ii);\r\n                            };\r\n                        })();\r\n                    }\r\n*/\r\n                },\r\n                \r\n            }     \r\n        });\r\n</script>\r\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
