<table>
  <tr>
    <th class="productPriceColumn">Price</th>
  </tr>
	{#foreach $T as productPrice}
	<tr>
    <td class="productPriceColumn">{$T.productPrice.Price}</td>
	</tr> 
	{#/for}
</table>