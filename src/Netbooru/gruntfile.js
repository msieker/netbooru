/// <binding AfterBuild='default' />
/*
This file in the main entry point for defining grunt tasks and using grunt plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkID=513275&clcid=0x409
*/
module.exports = function (grunt) {
	grunt.initConfig({
		bower: {
			install: {
				options: {
					targetDir: "wwwroot/lib",
					layout: "byComponent",
					cleanTargetDir: true
				}
			}
		},
		less: {
			development: {
				options: {
					paths: ["Assets"]
				},
				files: { "wwwroot/css/site.css": "assets/site.less" }
			}
		},
		uglify: {

		}
	});

	grunt.registerTask("default", ["bower:install", "less"]);

	grunt.loadNpmTasks("grunt-contrib-uglify");
	grunt.loadNpmTasks("grunt-contrib-watch");
	grunt.loadNpmTasks("grunt-bower-task");
	grunt.loadNpmTasks("grunt-contrib-less");
};