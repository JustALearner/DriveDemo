/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};

/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {

/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId])
/******/ 			return installedModules[moduleId].exports;

/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			exports: {},
/******/ 			id: moduleId,
/******/ 			loaded: false
/******/ 		};

/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);

/******/ 		// Flag the module as loaded
/******/ 		module.loaded = true;

/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}


/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;

/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;

/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";

/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ (function(module, exports) {

	'use strict';

	var _typeof = typeof Symbol === "function" && typeof Symbol.iterator === "symbol" ? function (obj) { return typeof obj; } : function (obj) { return obj && typeof Symbol === "function" && obj.constructor === Symbol && obj !== Symbol.prototype ? "symbol" : typeof obj; };

	$._ajax = $.ajax;
	$.ajax = function (option) {
	  var url = option.url;
	  if ((url.indexOf('http') !== -1 || url.indexOf('//') !== -1) && url.indexOf(location.hostname) === -1) {
	    if (navigator.userAgent.indexOf('MSIE 9.0') !== -1) {
	      // cross domain
	      var xdr = new XDomainRequest();
	      var method = (option.type || 'get').toUpperCase();
	      url += '?' + encodeURI(serialize(option.data));
	      xdr.open(method, url);
	      xdr.timeout = option.timeout || 30000;
	      xdr.onprogress = function () {};
	      xdr.onload = function () {
	        var response = xdr.responseText;
	        if (option.dataType === 'json') {
	          response = JSON.parse(response);
	        }
	        option.success(response);
	      };
	      xdr.onerror = option.error || function () {};

	      setTimeout(function () {
	        xdr.send();
	      }, 0);
	      return;
	    }
	  }
	  return $._ajax(option);
	};

	function serialize(d) {
	  if ($.isArray(d)) {
	    var o = {};
	    d.forEach(function (item) {
	      o[item.name] = item.value;
	    });
	    return $.param(o);
	  } else if ((typeof d === 'undefined' ? 'undefined' : _typeof(d)) === 'object') {
	    return $.param(d);
	  } else {
	    return d;
	  }
	}

/***/ })
/******/ ]);