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
  border: 2px solid var(--cor-fundo);
  outline: none;
  border-radius: 3px;
  box-sizing: border-box;
}

label {
  font-weight: bold;
  
}
</style>