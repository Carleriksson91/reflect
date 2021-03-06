﻿var gulp = require("gulp"),
    sass = require("gulp-sass"),
    concat = require("gulp-concat"),
    inject = require("gulp-inject");

var paths = {
    webroot: "./Features/Home/Static/",
    js: ["./Features/**/Static/*.js", "./Main/Static/js/*.js"],
    scss: ["./Features/**/Static/*.scss", "./Main/Static/scss/*.scss"],
    css: ["./Main/Static/css/*.css"],
    cssoutput: ["./Main/Static/css/"]
};

//paths.scss = paths.webroot + "home.scss";
//paths.css = paths.webroot;

gulp.task("index", function () {
      //return gulp.src('./Features/Layouts/beer.cshtml')
      //      .pipe(inject(gulp.src(paths.js, { read: false })))
      //      .pipe(gulp.dest('./Features'));
    return gulp.src("./Features/Layouts/beer.cshtml")
          .pipe(inject(gulp.src(paths.js, { read: false }), { relative: true }))
          .pipe(gulp.dest("./Features"))
          .pipe(inject(gulp.src(paths.css, { read: false }), { relative: true }), { name: 'css' })
          .pipe(gulp.dest("./Features"));

});
gulp.task("watch", function () {
    //gulp.watch(paths.js, ['min:js', browserSync.reload]);
    console.log(paths.scss);
    gulp.watch(paths.scss, ['sass']);
    gulp.watch([paths.js, paths.css], ["index"]);
});
 
gulp.task('sass', function () {
    return gulp.src(paths.scss)
        .pipe(sass())
        .pipe(concat("reflect.css"))
        .pipe(gulp.dest(paths.webroot));
});


gulp.task("default", ["watch", "index"]);