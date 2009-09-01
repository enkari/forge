(function($) {

	$(function() {
		$("a").filter(function() { return this.hostname && this.hostname !== location.hostname }).attr("rel", "external");
		$("a[rel='external']").addClass("external").attr("target", "_blank");
	});

})(jQuery);