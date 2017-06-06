About
=====

Project site: https://github.com/Tar-Palantir/EFTSQLDocumentation.Generator

Reads a db schema and then adds/updates the documentation in the matching `.emdx` file.

This is a fork of https://github.com/timabell/ef-document-generator

And the source came from http://eftsqldocgenerator.codeplex.com/

Usage
=====

	Run EFTSQLDocumentation.Form.exe
    (You can modify the config file before run the application.)

Arguments
---------

* connectionStrings:ConnStr ... ConnectionString of the documented database
* InputFileName ... original edmx file
* OutputFileName ... output edmx file - Default : original edmx file
* Xmlns ... edmx xml namespace
* SqlClient ... selected index in database server combobox

Download
========

[EFTSQLDocumentation.FormV1.0](https://github.com/Tar-Palantir/EFTSQLDocumentation.Generator/releases/download/1.0/EFTSQLDocumentation.FormV1.0.zip)