
(function($) {
	
	$.fn.defaultvalue = function() {
		
		// Scope
		var elements = this;
		var args = arguments;
		var c = 0;
		
		return(
			elements.each(function() {				
				
				// Default values within scope
				var el = $(this);
				var def = args[c++];

				el.val(def).focus(function() {
					if(el.val() == def) {
						el.val("");
					}
					el.blur(function() {
						if(el.val() == "") {
							el.val(def);
						}
					});
				});
				
			})
		);
	}
})(jQuery)