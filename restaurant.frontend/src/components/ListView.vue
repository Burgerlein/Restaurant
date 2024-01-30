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
    <h1 class="category">{{ category }}</h1>
    <div v-for="item in items[category]">
      <div v-if="filter === '' || item.attributes.includes(filter)" class="items">
        <h3>{{ item.name }}<span>{{ item.price }}</span></h3>
        <p>{{ item.description }}</p>
      </div>
    </div>
  </div>

  <datalist id="attributes">
    <option value="vegetarisch"></option>
  </datalist>
</template>
<style scoped>
* {
  margin: 0;
  animation: transitionIn 0.75s;
}
.category {
  color: var(--text-white);
  margin: 50px 0px 20px 0px;
  font-style: italic;
  font-size: 10vw;
}
.items {
  color: var(--text-white);
  margin: 10px 0px 10px 0px;
}
.items h3 span {
  padding-left: 10%;
}

@media only screen and (max-width: 600px) {
  .category {
    font-size: 17vw;
  }
}

</style>