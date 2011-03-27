<table>
  <tr>
    <th class="placeOrderColumn">
		&nbsp;
	</th>
  </tr>
	{#foreach $T as placeOrder}
	<tr>
		<td class="placeOrderColumn">	
			{#if $T.placeOrder.CanPlaceOrder == true}
				<form action="{$T.placeOrder.ActionUri}" method="post">
                    <input type="hidden" name="productId" value="{$T.placeOrder.Id}" />
                    <input type="text" name="quantity" />
                    <input type="submit" value="Place Order" />
                </form>
			{#else} 
				Unavailable
			{#/if}			
		</td>
	</tr>
	{#/for}
</table>