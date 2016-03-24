@Code
    ViewData("Title") = "Osmaniye Belediyesi"
  
End Code

<div class="container">
    <div class="row">
        <div class="col-md-9">

            <img src="~/Content/img/dadad.jpg" />
        </div>
        <div class="col-md-3">
            <div class="search">
                <label for="mod-search-searchword">.</label><input name="searchword" id="mod-search-searchword" maxlength="20" class="inputbox" type="text" size="35" value="Arama..." onblur="if (this.value=='') this.value='Arama...';" onfocus="if (this.value=='Arama...') this.value='';"><span class="osm-button-wrapper"><span class="osm-button-l"> </span><span class="osm-button-r"> </span><input type="image" value="Ara" class="button osm-button" src="/" onclick="this.form.searchword.focus();" style="zoom: 1;"></span>	<input type="hidden" name="task" value="search">
                <input type="hidden" name="option" value="com_search">
                <input type="hidden" name="Itemid" value="101">
            </div>
        </div>
        </div>

    <br>


    </br>
    <br>


    </br>
        <div class=" row">

            <div id="myCarousel" class="carousel slide" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                    <li data-target="#myCarousel" data-slide-to="3"></li>
                </ol>

                <!-- Wrapper for slides -->
                <div class="carousel-inner" role="listbox">
                    <div class="item active">

                        <img src="~/Content/img/fotograf_yarismasi_3.jpg" alt="Flower">
                    </div>

                    <div class="item">

                        <img src="~/Content/img/hosgeldin_bebek.jpg" alt="Flower">
                    </div>

                    <div class="item">

                        <img src="~/Content/img/kentmuzesi.jpg" alt="Flower">
                    </div>

                    <div class="item">
                        <img src="~/Content/img/muhtarlar_masasi.jpg" alt="Flower">
                        
                    </div>
                </div>

                <!-- Left and right controls -->
                <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                    <span class="sr-only">Geri</span>
                </a>
                <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                    <span class="sr-only">İleri</span>
                </a>
            </div>

        </div>
        <div class="row">

            

        <div class="col-md-3" >
            
           
        </div>
            <div class="col-md-9">

                sağ taraf

            </div>
        </div>

    </div>
</div>
