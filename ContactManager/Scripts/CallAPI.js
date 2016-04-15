console.log('datos cargados')


console.log("information reddit");

console.log('hola mundo')
$.ajax({
    //url: "https://api.flickr.com/services/feeds/photos_public.gne?format=json&tag=animals",
    url: "http://api.flickr.com/services/rest/?method=flickr.photos.search&api_key={0d28d131bc425440370cad6976a7d7dc}&tags=flower&per_page=3",
    dataType: "jsonp",
    jsonpCallback: 'jsonFlickrFeed',
    cache: false,
    succes: function (e) {
        console.log(e);
    },
    error: function (e) {

        console.log(e);
    }   
});