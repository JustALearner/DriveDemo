(function (d) {
    var e = document, l = d.location; if (!d.TJ58) {
        d.TJ58 = !0; null == d.String.prototype.trim && (d.String.prototype.trim = function () { return this.replace(/^\s\s*/, "").replace(/\s\s*$/, "") }); var c = {
            curURL: l.href, referrer: e.referrer, domain: function () { var a = l.host.toLowerCase(), b = /.*?([^\.]+\.(com|org|net|biz|edu|cc)(\.[^\.]+)?)/; return b.test(a) ? "." + a.replace(b, "$1") : "" }(), window_size: e.documentElement.clientWidth + "x" + e.documentElement.clientHeight, setCookie: function () {
                if (!e.cookie) return !1; var a = new Date;
                2 < arguments.length ? a.setTime(a.getTime() + 864E5 * arguments[2]) : a.setTime(a.getTime() + 18E5); 2 <= arguments.length && (e.cookie = arguments[0] + "=" + escape(arguments[1]) + "; expires=" + a.toGMTString() + "; domain=" + c.domain + "; path=/")
            }, getCookie: function (a) { var b; return (b = e.cookie.match(RegExp("(^| )" + a + "=([^;]*)(;|$)"))) ? unescape(b[2]) : "" }, ajaxsend: function (a) { (new Image).src = a }, setLocalStorage: function (a, b) { if (d.localStorage) try { d.localStorage.setItem(a, b) } catch (c) { } }, getLocalStorage: function (a) {
                return d.localStorage ?
                d.localStorage.getItem(a) : ""
            }, getUUID: function (a) { var b = "xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx".replace(/[xy]/g, function (a) { var b = 16 * d.Math.random() | 0; return ("x" == a ? b : b & 3 | 8).toString(16) }), b = this.getCookie(a) || this.getLocalStorage(a) || b; this.setCookie(a, b, 365); this.setLocalStorage(a, b); return b }, getRandom: function () { return d.Math.random() }
        }, h = {
            config: {
                trackLog: {
                    server: "tracklog.58.com/jxedt_pc/empty.js.gif", allParams: "site_name tag referrer _ga_utma window_size trackURL rand_id".split(" "), uniqParams: ["tag",
                    "rand_id"]
                }, clickLog: { server: "tracklog.58.com/jxedt_pc/click/empty.js.gif", allParams: "site_name tag from trackURL referrer rand".split(" "), uniqParams: ["tag", "from", "rand"] }
            }, getBaseInfo: function () {
                var a = d.site_name || "jxedt", b = d.encodeURIComponent(c.referrer), e = c.getUUID("58tj_uuid"), h = c.window_size, k = c.getCookie("als"), f = d._trackURL || "NA", g, m, n; "" != c.getCookie("new_session") ? (g = c.getCookie("init_refer"), m = "0") : (g = d.encodeURIComponent(c.referrer), m = "1"); n = "" != c.getCookie("new_uv") ? parseInt(c.getCookie("new_uv")) +
                ("0" == m ? 0 : 1) : 1; c.setCookie("new_session", m); c.setCookie("init_refer", g); c.setCookie("new_uv", n, 365); var l = "1.1.1.1.1." + n, p = [], r = f.indexOf("{"), k = { als: k, new_session: m, init_refer: g, new_uv: n, UUID: e }, q; for (q in k) k.hasOwnProperty(q) && p.push("'" + q + "':'" + k[q] + "'"); p.join(","); f = "NA" !== f && -1 !== r ? f.substring(0, r + 1) + p + "," + f.substring(r + 1) : "{" + p + "}"; return { site_name: a, referrer: b, UUID: e, window_size: h, _ga_utma: l, trackURL: f }
            }, sendLog: function (a, b) {
                var d = this.baseInfo, e = this.config[a]; if (a && e && b && "object" === typeof b) {
                    for (var k =
                    [], f = e.allParams, g = 0, h = f.length; g < h; g++) k.push(f[g] + "=" + (b[f[g]] || d[f[g]] || "")); c.ajaxsend(l.protocol + "//" + e.server + "?" + k.join("&"))
                }
            }, trackLog: function () { this.sendLog("trackLog", { tag: "pvstatall", rand_id: c.getRandom() }) }, clickLog: function (a) { var b = "", b = null != a && "from=" === a.substring(0, 5) ? a.replace("from=", "") : "default&" + a; this.sendLog("clickLog", { tag: "pvsiters", from: b, rand: c.getRandom() }) }, bindAlsTag: function () {
                if (!c.getCookie("als") && d.$ && "function" === typeof $("body").one) $("body").one("mouseover",
                function () { c.setCookie("als", "0", 365) }); c.getCookie("isSpider") && c.setCookie("isSpider", "", 0)
            }
        }; h.baseInfo = h.getBaseInfo(); h.trackLog(); h.bindAlsTag(); d.clickLog = function (a) { h.clickLog(a) }
    }
})(window);
