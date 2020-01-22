function genre(id, type) {
    return {
        id: ko.observable(id),
        type: ko.observable(type),
        movies: ko.observableArray([])
        //players: ko.observableArray([]),
        
    };
}
function movie(id, title, genreid) {
    return {
        id: ko.observable(id),
        title: ko.observable(title),
        genreid: ko.observable(genreid)
    };
}