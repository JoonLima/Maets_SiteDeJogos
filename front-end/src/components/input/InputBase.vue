<template>
  <div>
    <label for="" :placeholder="placeHolder">{{ label }}</label>
    <input :type="type" :placeholder="placeHolder" />
  </div>
</template>

<script>
export default {
  name: "InputBase",
  props: {
    label: { type: String, require },
    placeHolder: { type: String },
    type: { type: String, default: "text" },
  },
  data() {
    return {};
  },
};
</script>

<style scoped>
input {
  width: 100%;
  padding: 10px;
  margin: 8px 0px;
  display: inline-block;
  border: 1px solid #ddd;
  outline: none;
  border-radius: 2px;
  box-sizing: border-box;
  background-color: #32353c;
}

label {
  font-weight: bold;
  color: #ddd;
}
</style>