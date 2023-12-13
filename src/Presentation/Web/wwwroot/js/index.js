// src/tag.ts
var createTag = (text) => {
  var li = document.createElement("li");
  li.appendChild(document.createTextNode(text));
  return li;
};
// src/pages/home.ts
var page = document.getElementById("home");
var tag = page?.getElementsByClassName("tags")[0];
for (let i = 0;i < 60; i++) {
  tag?.appendChild(createTag("test"));
}
export {
  createTag
};
