<script setup lang="ts">
import json from "@/json/menu.json";
import { ref } from "vue";

interface MenuItem {
  name: string;
  price: number;
  description: string;
  attributes: string[];
}

interface Menu {
  [category: string]: MenuItem[];
}

const items: Menu = json;
const filter = ref("");
</script>
<template>
  <input type="search" list="attributes" v-model="filter" />

  <div v-for="category in Object.keys(items)">
    <h1>{{ category }}</h1>
    <div v-for="item in items[category]">
      <div v-if="filter === '' || item.attributes.includes(filter)">
        <h3>{{ item.name }}</h3>
        <a>{{ item.price }}</a>
        <p>{{ item.description }}</p>
      </div>
    </div>
  </div>

  <datalist id="attributes">
    <option value="vegan"></option>
    <option value="vegetarisch"></option>
    <option value="spicy"></option>
  </datalist>
</template>
<style scoped>
* {
  margin: 0;
  color: lightgoldenrodyellow;
}
div:first-child {
  margin: 0;
}
div {
  margin: 2%;
}
input {
  color: black;
}
</style>