import { createTag } from '../index'

let page = document.getElementById("home");

let tag = page?.getElementsByClassName("tags")[0];
for (let i = 0; i < 60; i++) {
	tag?.appendChild(createTag("test"));
}

