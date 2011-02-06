<table>
  <tr>
    <th class="productIdColumn">Id</th>
    <th class="productNameColumn">Product Name</th>
  </tr>
	{#foreach $T as product}
	<tr>
    <td class="productIdColumn">{$T.product.Id}</td>
		<td class="productNameColumn">{$T.product.Name}</td>
	</tr>
	{#/for}
</table>
