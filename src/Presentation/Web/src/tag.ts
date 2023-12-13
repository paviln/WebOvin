export const createTag = (text: string) => {
	var li = document.createElement("li");
	li.appendChild(document.createTextNode(text))

	return li;
}