var gulp = require("gulp"),
    sass = require("gulp-sass"),
    concat = require("gulp-concat");

var paths = {
    webroot: "./Features/Home/Static/"
};



paths.scss = paths.webroot + "home.scss";
paths.css = paths.webroot;


gulp.task("watch", function () {
    //gulp.watch(paths.js, ['min:js', browserSync.reload]);
    console.log(paths.scss);
    gulp.watch(paths.scss, ['sass']);
});

gulp.task('sass', function () {
    return gulp.src(paths.scss)
        .pipe(sass())
        .pipe(concat("foundation.css"))
        .pipe(gulp.dest(paths.css));
});


gulp.task("default", ["watch"]);